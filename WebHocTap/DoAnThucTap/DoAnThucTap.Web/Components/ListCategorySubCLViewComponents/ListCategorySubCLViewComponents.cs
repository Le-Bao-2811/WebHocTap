using DoAnThucTap.Data.Reponsitory;
using Microsoft.AspNetCore.Mvc;

namespace DoAnThucTap.Web.Components.ListCategorySubCLViewComponents
{
    public class ListCategorySubCLViewComponents:ViewComponent
    {
        public readonly BaseReponsitory _repo;
        public ListCategorySubCLViewComponents(BaseReponsitory repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
