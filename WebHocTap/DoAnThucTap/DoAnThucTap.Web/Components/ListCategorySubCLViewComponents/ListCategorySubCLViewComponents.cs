using DoAnThucTap.Data.Entites;
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
            var data = _repo.GetAll<CategorySub>().Take(8).ToList();
            foreach(var item in data)
            {
                var dataItem=_repo.GetAll<Subject>().Where(x=>x.IdCategorySub==item.Id).ToList();
                item.subjects = dataItem;
            }
            return View(data);
        }
    }
}
