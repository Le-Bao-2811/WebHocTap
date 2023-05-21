﻿using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DoAnThucTap.Web.Areas.Admin.Components.ListRole
{
    public class ListRoleViewComponents : ViewComponent
    {
        readonly BaseReponsitory repository;
        public ListRoleViewComponents(BaseReponsitory _repository)
        {
            repository = _repository;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? selected)
        {
            var data = await repository.GetAll<Role>().ToListAsync();
            if (selected != null)
            {
                ViewBag.selected = selected;
            }
            return View(data);
        }
    }
}
