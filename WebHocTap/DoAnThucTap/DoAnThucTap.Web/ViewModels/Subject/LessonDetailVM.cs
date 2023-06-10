using DoAnThucTap.Data.Entites;

namespace DoAnThucTap.Web.ViewModels.Subject
{
    public class LessonDetailVM
    {
        public bool IsTest { get; set; }
        public DoAnThucTap.Data.Entites.Subject subject { get; set; }
        public List<Chapter> chapters { get; set; }
        public List<Lesson> lessons { get; set; }
    }
}
