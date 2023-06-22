﻿using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using DoAnThucTap.Share.Const;
using DoAnThucTap.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using PayPal.Core;
using PayPal.v1.Payments;
using PayPal.v1.Orders;
using BraintreeHttp;
using DoAnThucTap.Web.Common;
using X.PagedList;

namespace DoAnThucTap.Web.Controllers
{
    public class HomeController : BaseClientController
    {

        private readonly ILogger<HomeController> _logger;
        private readonly string _clientId;
        private readonly string _secretKey;
        public readonly int USD;
        public HomeController(ILogger<HomeController> logger,BaseReponsitory repo,IConfiguration configuration):base(repo)
        {
            _logger = logger;
            _clientId = configuration["PaypalSetting:ClientID"];
            _secretKey = configuration["PaypalSetting:SecretKey"];
            USD = 23000;
        }
        public IActionResult Index()
        {
            return View();
        }
        // trag xem khóa học tra tiền để quyết định có mua hay k
        [AppAuthorize]
        public async Task<IActionResult> DetailSub(int id)
        {
            var data=await _repo.FindAsync<CategorySub>(id);
            return View(data);
        }
        [AppAuthorize]
        public async Task<IActionResult> PaypalCheckOut(int id)
        {
            var categorysub=await _repo.FindAsync<CategorySub>(id);
            var environment = new SandboxEnvironment(_clientId, _secretKey);
            var client = new PayPalHttpClient(environment);
            var itemList = new ItemList()
            {
                Items = new List<PayPal.v1.Payments.Item>()
            };
            var priceUSD = Math.Round(Convert.ToDecimal(categorysub.Price / USD), 2);
            itemList.Items.Add(new PayPal.v1.Payments.Item()
            {
                Name = categorysub.NameCategorySub,
                Currency = "USD",
                Price = priceUSD.ToString(),
                Quantity = "1",
                Sku = "sku",
                Tax = "0"
            });




            var paypalOrderId = DateTime.Now.Ticks;
            var hostname = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new PayPal.v1.Payments.Amount()
                        {
                            Total = priceUSD.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = priceUSD.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = $"Invoice #{paypalOrderId}",
                        InvoiceNumber = paypalOrderId.ToString()
                    }
                },
                RedirectUrls = new PayPal.v1.Payments.RedirectUrls()
                {
                    CancelUrl = $"{hostname}/Home/CheckoutFail",
                    ReturnUrl = $"{hostname}/Home/CheckoutSuccess/{categorysub.Id}"
                },
                Payer = new PayPal.v1.Payments.Payer()
                {
                    PaymentMethod = "paypal"
                }
            };
           
            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                var response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    PayPal.v1.Payments.LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }
                
                return Redirect(paypalRedirectUrl);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                //Process when Checkout with Paypal fails
                return Redirect("/Home/CheckoutFail");
            }
        }
        public async Task<IActionResult> CheckoutSuccess(int id)
        {
            var subject = await _repo.FindAsync<CategorySub>(id);
            var purchasedCourse = new PurchasedCourse();
            purchasedCourse.IdUser = Convert.ToInt32(User.Claims.SingleOrDefault(c => c.Type.Contains(System.Security.Claims.ClaimTypes.NameIdentifier))?.Value);
            purchasedCourse.IdSub = id;
            purchasedCourse.Price=subject.Price;
            await _repo.AddAsync(purchasedCourse);
            return View();
        }
        public IActionResult CheckoutFail()
        {
            return View();
        }
        public IActionResult ListCateSubFree(int page=1,int size=10)
        {
            var data=_repo.GetAll<CategorySub>(x=>x.Price==null).ToPagedList(page,size);
            return View(data);
        }
        public IActionResult ListCateSubPay(int page = 1, int size = 10)
        {
            var iduser = Convert.ToInt32(User.Claims.SingleOrDefault(c => c.Type.Contains(System.Security.Claims.ClaimTypes.NameIdentifier))?.Value);
            if (iduser != 0 ) {
                var key = _repo.GetAll<PurchasedCourse>(x => x.IdUser == iduser).ToList();
                var categorysub = _repo.GetAll<CategorySub>(x => x.Price != null).ToPagedList(page, size);
                var data = new List<CategorySub>();
                foreach (var c in categorysub)
                {
                    var check = false;
                    foreach (var k in key)
                    {
                        if (c.Id == k.IdSub)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        data.Add(c);
                    }
                }
                var data1 = data.ToPagedList(page, size);
                return View(data1);
            }
            else
            {
                var data = _repo.GetAll<CategorySub>(x => x.Price != null).ToPagedList(page, size);
                return View(data);
            }



        }
        public IActionResult ListSubUserBuy() { 
            var categorysub= _repo.GetAll<CategorySub>().ToList();
            var iduser = Convert.ToInt32(User.Claims.SingleOrDefault(c => c.Type.Contains(System.Security.Claims.ClaimTypes.NameIdentifier))?.Value);
            var key = _repo.GetAll<PurchasedCourse>(x => x.IdUser == iduser).ToList();
            var data = new List<CategorySub>();
            foreach (var c in categorysub)
            {
                foreach (var k in key)
                {
                    if (c.Id == k.IdSub)
                    {
                        data.Add(c);
                    }
                }
            }
            return View(data);
        }
    }
}