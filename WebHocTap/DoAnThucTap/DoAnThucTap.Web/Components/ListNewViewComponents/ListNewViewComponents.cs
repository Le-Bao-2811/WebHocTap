using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using DoAnThucTap.Web.Areas.Admin.Controllers;
using DoAnThucTap.Web.WebConfig;
using Microsoft.AspNetCore.Mvc;

namespace DoAnThucTap.Web.Components.ListNewViewComponents
{
    public class ListNewViewComponents:ViewComponent
    {
        public readonly BaseReponsitory _repo;
        public ListNewViewComponents(BaseReponsitory repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
           var data= _repo.GetAll<CategoryNew,ListNewVM>(MapperConfig.ListCateNewClIndexConf).ToList();
            return View(data);
        }
    }
}
