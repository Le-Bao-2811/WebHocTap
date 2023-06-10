using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using X.PagedList;

namespace DoAnThucTap.Web.Components.ListCategorySubPaymentViewComponents
{
    public class ListCategorySubPaymentViewComponents:ViewComponent
    {
        public readonly BaseReponsitory _repo;
        public ListCategorySubPaymentViewComponents(BaseReponsitory repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync(int iduser)
        {

            if (iduser != 0)
            {
                var key = _repo.GetAll<PurchasedCourse>(x => x.IdUser == iduser).ToList();
                var categorysub = _repo.GetAll<CategorySub>(x => x.Price != null).ToList();
                var data = new List<CategorySub>();
                foreach (var c in categorysub)
                {
                    foreach (var k in key)
                    {
                        if (c.Id != k.IdSub)
                        {
                            data.Add(c);
                        }
                    }
                }
                // lọc lại những phần tử trùng nhau ở vòng lặp ở trên
                for (int i = 0; i < data.Count(); i++)
                {
                    for (int j = +1; j < data.Count(); j++)
                    {
                        if (data[i].Id == data[j].Id)
                        {
                            data.RemoveAt(j);
                        }
                    }
                }
                var data1 = data.Take(8).ToList();
                return View(data1);
            }
            else
            {
                var data = _repo.GetAll<CategorySub>(x => x.Price != null).Take(8).ToList();
                return View(data);
            }


            //var data = _repo.GetAll<CategorySub>(x=>x.Price!=null).Take(8).ToList();
            //return View(data);
        }
    }
}
