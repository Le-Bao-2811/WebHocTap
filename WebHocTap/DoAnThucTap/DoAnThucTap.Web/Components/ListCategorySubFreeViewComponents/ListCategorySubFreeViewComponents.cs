﻿using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using Microsoft.AspNetCore.Mvc;

namespace DoAnThucTap.Web.Components.ListCategorySubFreeViewComponents
{
    public class ListCategorySubFreeViewComponents : ViewComponent
    {
        public readonly BaseReponsitory _repo;
        public ListCategorySubFreeViewComponents(BaseReponsitory repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = _repo.GetAll<CategorySub>(x=>x.Price==null).Take(8).ToList();
            return View(data);
        }
    }
}