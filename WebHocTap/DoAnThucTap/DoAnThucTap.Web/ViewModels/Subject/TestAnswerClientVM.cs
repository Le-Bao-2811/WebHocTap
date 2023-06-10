using DoAnThucTap.Data.Entites;

namespace DoAnThucTap.Web.ViewModels.Subject
{
    public class TestAnswerClientVM
    {
        public int Id { get; set; }
        public int? IdChapter { get; set; }
        public string Question { get; set; }
        public List<Answer> answers { get; set; }
    }
}
