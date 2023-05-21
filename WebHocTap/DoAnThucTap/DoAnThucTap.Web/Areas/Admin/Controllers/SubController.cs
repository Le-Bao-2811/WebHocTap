using AutoMapper;
using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using DoAnThucTap.Share.Const;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Chapter;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Sub;
using DoAnThucTap.Web.Common;
using DoAnThucTap.Web.WebConfig;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DoAnThucTap.Web.Areas.Admin.Controllers
{
    public class SubController : BaseAdminController
    {
        public readonly IMapper _mapper;
        public SubController(BaseReponsitory _repo,IMapper mapper):base(_repo)
        {
            _mapper = mapper;
        }
        [AppAuthorize(AuthConst.Subject.VIEW_LIST)]
        public IActionResult Index(int page=1,int size=10)
        {
            var data= _repo.GetAll<Subject,ListSubItemVM>(MapperConfig.SubIndexConf)
                .ToPagedList(page, size);
            return View(data);
        }
        [AppAuthorize(AuthConst.Subject.CREATE)]
        public IActionResult _Create()
        {
            return PartialView();
        }
        [HttpPost]
        [AppAuthorize(AuthConst.Subject.CREATE)]
        public async Task<IActionResult> _Create(AddorUpdateSubVM model)
        {
            var data= _mapper.Map<Subject>(model);
            await _repo.AddAsync(data);
            SetSuccessMesg("Thêm thành công");
            return Ok(true);
        }
        public async Task<IActionResult> _Update(int id)
        {
            var data = await _repo.GetOneAsync<Subject, AddorUpdateSubVM>(id, s => new AddorUpdateSubVM
            {
                Id = s.Id,
                NameSubject = s.NameSubject,
                IdCategorySub = s.IdCategorySub,
            });
            return PartialView(data);
        }
        [HttpPost]
        public async Task<IActionResult>_Update(AddorUpdateSubVM model)
        {
            var data= await _repo.FindAsync<Subject>(model.Id);
            if (data != null)
            {
                _mapper.Map<AddorUpdateSubVM,Subject>(model,data);
                await _repo.UpdateAsync(data);
                SetSuccessMesg("Cập nhật thành công");
            }
            return Ok(true);
        }
        public async Task<IActionResult>Delete(int id)
        {
            var data= await _repo.FindAsync<Subject>(id);
            await _repo.DeleteAsync(data);
            SetSuccessMesg("Xóa môn học thành công");
            return RedirectToAction("Index");
        }
    }
}
