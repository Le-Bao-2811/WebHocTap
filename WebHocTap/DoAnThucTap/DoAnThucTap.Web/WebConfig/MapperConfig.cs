﻿using AutoMapper;
using DoAnThucTap.Data.Entites;
using DoAnThucTap.Web.Areas.Admin.ViewModels.CategoryNew;
using DoAnThucTap.Web.Areas.Admin.ViewModels.CategorySub;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Chapter;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Home;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Lesson;
using DoAnThucTap.Web.Areas.Admin.ViewModels.News;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Role;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Sub;
using DoAnThucTap.Web.Areas.Admin.ViewModels.Test;
using DoAnThucTap.Web.Areas.Admin.ViewModels.TestandAnswer;
using DoAnThucTap.Web.Areas.Admin.ViewModels.User;
using DoAnThucTap.Web.Components.ListNewViewComponents;
using DoAnThucTap.Web.ViewModels;
using DoAnThucTap.Web.ViewModels.Account;
using DoAnThucTap.Web.ViewModels.Subject;

namespace DoAnThucTap.Web.WebConfig
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User,AddUserVM>().ReverseMap();
            CreateMap<CategoryNew,AddorUpdateCategoryNewVM>().ReverseMap();
            CreateMap<News,AddorUpdateNewsVM>().ReverseMap();
            CreateMap<CategorySub,AddorUpdateCategorySubVM>().ReverseMap();
            CreateMap<Subject,AddorUpdateSubVM>().ReverseMap();
            CreateMap<Chapter,AddorUpdateChappterVM>().ReverseMap();
            CreateMap<Lesson,AddorUpdateLessonVM>().ReverseMap();
            CreateMap<Answer,UpdateAnswerVM>().ReverseMap();
            CreateMap<User,SignUpVM>().ReverseMap();
        }
        public static MapperConfiguration RoleIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Role, ListRoleItemVM>();
        });
        public static MapperConfiguration UserIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<User, ListUserItemVM>()
            .ForMember(uItem=>uItem.RoleName,
            otps=>otps.MapFrom(uE=>uE.role.RoleName));
        });
        public static MapperConfiguration LoginConf = new(mapper =>
        {
            // Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
            mapper.CreateMap<User, UserDataForApp>()
                .ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.role == null ? "" : uEntity.role.RoleName))
                .ForMember(uItem => uItem.Permission, opts => opts.MapFrom
                (
                    uEntity => string.Join(',', uEntity.role
                                                        .rolePermissions
                                                        .Select(p => p.MStPermissionId))
                )
            );
        });
        public static MapperConfiguration CategoryNewIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<CategoryNew, ListCategoryItemVM>();
        });
        public static MapperConfiguration NewsIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<News, ListNewsItemVM>()
            .ForMember(uItem => uItem.IdCategoryNew,
            otps => otps.MapFrom(uE => uE.categoryNew.NameCategoryNew));
        });
        public static MapperConfiguration CategorySubIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<CategorySub, ListCategorySubItemVM>();
        });
        public static MapperConfiguration SubIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Subject, ListSubItemVM>()
            .ForMember(uItem => uItem.CategorySub,
            otps => otps.MapFrom(uE => uE.categorySub.NameCategorySub));
        });
        public static MapperConfiguration ChapterIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Chapter, ListChapterItemVM>();
        });
        public static MapperConfiguration LessonIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Lesson, ListLessonItemVM>();
        });
        public static MapperConfiguration TestIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Test, ListTestItemVM>();
        });
        public static MapperConfiguration ListAnswerIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Answer, ListAnswerItemVM>();
        });
        public static MapperConfiguration ListTestAnswerIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<Test, TestAnswerClientVM>();
        });
        public static MapperConfiguration ListCateNewClIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<CategoryNew, ListNewVM>();
        });
        public static MapperConfiguration PurchasedCourseIndexConf = new(mapper =>
        {
            // Map dữ liệu từ kiểu AppRole sang RoleListItemVM
            mapper.CreateMap<PurchasedCourse, ListPurchasedCourseItem>()
            .ForMember(uItem => uItem.UserName,
            otps => otps.MapFrom(uE => uE.user.UserName))
            .ForMember(uItem => uItem.SubName,
            otps => otps.MapFrom(uE => uE.subject.NameCategorySub));
        });
    }
}
