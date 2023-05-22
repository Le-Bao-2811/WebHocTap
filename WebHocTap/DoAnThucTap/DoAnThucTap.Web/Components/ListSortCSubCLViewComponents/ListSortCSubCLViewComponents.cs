using DoAnThucTap.Data.Reponsitory;
using Microsoft.AspNetCore.Mvc;

namespace DoAnThucTap.Web.Components.ListSortCSubCLViewComponents
{
    public class ListSortCSubCLViewComponents:ViewComponent
    {
        public readonly BaseReponsitory _repo;
        public ListSortCSubCLViewComponents(BaseReponsitory repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
