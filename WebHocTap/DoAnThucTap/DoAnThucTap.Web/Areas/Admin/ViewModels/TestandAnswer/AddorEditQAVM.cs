﻿namespace DoAnThucTap.Web.Areas.Admin.ViewModels.TestandAnswer
{
    public class AddorEditQAVM
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int? IdLesson { get; set; }
        public string AnswerSucces { get; set; }

        public List<string> AnswerFail { get; set; }
    }
}
