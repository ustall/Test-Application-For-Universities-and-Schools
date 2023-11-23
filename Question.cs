namespace mgri_tests
{
    //конструктор объекта вопрос
    public class Question
    {
        public string MainQuestion { get; set; }
        public string Variants { get; set; }
        public string Answer { get; set; }

        public Question(string mainQuestion, string variants, string answer)
        {
            MainQuestion = mainQuestion;
            Variants = variants;
            Answer = answer;
        }
    }
}
