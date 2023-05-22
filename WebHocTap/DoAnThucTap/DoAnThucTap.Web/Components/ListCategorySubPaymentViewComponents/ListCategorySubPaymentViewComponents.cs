using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using Microsoft.AspNetCore.Mvc;

namespace DoAnThucTap.Web.Components.ListCategorySubPaymentViewComponents
{
    public class ListCategorySubPaymentViewComponents:ViewComponent
    {
        public readonly BaseReponsitory _repo;
        public ListCategorySubPaymentViewComponents(BaseReponsitory repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = _repo.GetAll<CategorySub>().Where(x=>x.isPayment==true).Take(8).ToList();
            return View(data);
        }
    }
}
