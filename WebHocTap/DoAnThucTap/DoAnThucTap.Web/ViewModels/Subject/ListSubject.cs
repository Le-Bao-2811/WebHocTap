using DoAnThucTap.Data.Entites;

namespace DoAnThucTap.Web.ViewModels.Subject
{
    public class ListSubject
    {
        public int Id { get; set; }
        public string NameCategorySub { get; set; }
        public List<DoAnThucTap.Data.Entites.Subject> subjects { get; set; }
        public List<Chapter> chapters { get; set; }
    }
}
