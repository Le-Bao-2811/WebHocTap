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
            return View();
        }
    }
}
