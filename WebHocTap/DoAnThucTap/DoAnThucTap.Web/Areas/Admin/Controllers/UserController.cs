using AutoMapper;
using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using DoAnThucTap.Share.Const;
using DoAnThucTap.Web.Areas.Admin.ViewModels.User;
using DoAnThucTap.Web.Common;
using DoAnThucTap.Web.WebConfig;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DoAnThucTap.Web.Areas.Admin.Controllers
{
    public class UserController : BaseAdminController
    {
        public readonly IMapper _mapper;
        public UserController(BaseReponsitory _repo,IMapper mapper):base(_repo)
        {
            _mapper = mapper;
        }
        [AppAuthorize(AuthConst.User.VIEW_LIST)]
        public IActionResult Index(int page=1,int size=10)
        {
            var data = _repo.GetAll<User, ListUserItemVM>(MapperConfig.UserIndexConf)
                .ToPagedList(page, size);
            return View(data);
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserVM model) {
            if (!ModelState.IsValid)
            {
                SetErrorMesg("Dữ liệu không hợp lệ vui lòng kiểm tra lại!");
                return View(model);
            }
            model.UserName = model.UserName.ToLower();
            if (await _repo.AnyAsync<User>(x => x.UserName == model.UserName))
            {
                SetErrorMesg("Tên đăng nhập đã tồn tại vui lòng kiểm tra lại!");
                return View(model);
            }

            if (model.IsSubmit == false)
            {
                SetErrorMesg("Bạn chưa đồng ý điều khoản và điều kiện!");
                return View(model);
            }
            try
            {
                var hashResult = HashHMACSHA512(model.Password);
                model.PasswordHash = hashResult.Value;
                model.PasswordSalt = hashResult.Key;
                var user = _mapper.Map<User>(model);
                await _repo.AddAsync(user);
                SetSuccessMesg($"Thêm tài khoản [{user.UserName}] thành công");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }
    }
}
