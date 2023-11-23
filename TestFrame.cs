using System;
using System.Drawing;
using System.Windows.Forms;

namespace mgri_tests
{
    public partial class TestFrame : Form
    {
        private Question[] questions;
        private int currentQuestionIndex;
        private int score = 0;
        private bool showAnswer = false;

        // Конструктор формы
        public TestFrame(int testd)
        {

            InitializeComponent();
            // Инициализируем массив вопросов с помощью вашей функции CreateQuestions
            Questions = QuestionManager.CreateQuestions(testd); // Предполагаем, что у вас есть QuestionManager с этой функцией
            // Инициализируем индекс текущего вопроса
            CurrentQuestionIndex = 0;
            // Показываем первый вопрос
            ShowCurrentQuestion();
        }

        public Question[] Questions { get => questions; set => questions = value; }
        public int CurrentQuestionIndex { get => currentQuestionIndex; set => currentQuestionIndex = value; }
        public int Score { get => score; set => score = value; }
        public bool ShowAnswer { get => showAnswer; set => showAnswer = value; }

        //Вызов следующего вопроса
        public void ShowCurrentQuestion()
        {

            Question question = Questions[CurrentQuestionIndex];
            if (CurrentQuestionIndex >= 0 && CurrentQuestionIndex < Questions.Length)
            {
                MainQuestionLB.Text = Questions[CurrentQuestionIndex].MainQuestion;
                VariantLB.Text = Questions[CurrentQuestionIndex].Variants;
                if (showAnswer)
                {
                    Answer.Text = question.Answer;
                }
                else
                {
                    Answer.Text = string.Empty;
                }
            }
            else
            {
                MainQuestionLB.Text = "Вы прошли тест";
                //SubQuestionLB.Text = showAnswer ? $"Ваш результат {Score} из {Questions.Length}" : string.Empty;
            }
        }
        //Вызов ответов в режиме обучения
        public void ShowCurrentQuestionAnswer()
        {

            Question question = Questions[CurrentQuestionIndex];
            if (CurrentQuestionIndex >= 0 && CurrentQuestionIndex < Questions.Length)
            {
                MainQuestionLB.Text = Questions[CurrentQuestionIndex].MainQuestion;
                VariantLB.Text = Questions[CurrentQuestionIndex].Variants;
                Answer.Text = Questions[CurrentQuestionIndex].Answer;
            }
        }
        //messageBox SCORE
        private void messageBoxScore(int score, int QuestionsLength)
        {
            string message = $"Вы прошли тест! Ваш результат {score} из {QuestionsLength}\nВы можете посмотреть правильные ответы";
            MessageBox.Show(message, string.Empty, MessageBoxButtons.OK);
        }
        //обработчик нажатия на кноку Далее
        private void next_Click(object sender, EventArgs e)
        {
            // Обработчик события для кнопки "Следующий вопрос"
            // Переходим к следующему вопросу, если это возможно
            if (!showAnswer)
            {
                if (CurrentQuestionIndex < Questions.Length - 1)
                {
                    if (Answer.Text == Questions[CurrentQuestionIndex].Answer)
                        Score++;
                    CurrentQuestionIndex++;
                    ShowCurrentQuestion();
                }
                else
                {
                    if (Answer.Text == Questions[CurrentQuestionIndex].Answer)
                        Score++;
                    messageBoxScore(Score, Questions.Length);//MessageBoxScore Call
                    //Main
                    MainQuestionLB.Text = "Вы прошли тест";
                    MainQuestionLB.ForeColor = Color.LimeGreen;
                    MainQuestionLB.Font = new Font("Calibri", 20F);
                    if (Score > Questions.Length / 2) { VariantLB.ForeColor = Color.Green; } else { VariantLB.ForeColor = Color.Red; }
                    VariantLB.Text = $"Ваш результат {Score} из {Questions.Length}";
                    VariantLB.Font = new Font("Calibri", 20F);
                    Answer.Text = "";
                    next.Text = "Ответы";
                    next.BackColor = Color.LightBlue;
                    showAnswer = true;
                    CurrentQuestionIndex = 0;
                }
            }
            else
            {
                Answer.ReadOnly = true;
                Answer.ShortcutsEnabled = false;
                Answer.ForeColor = Color.Black;
                AnsLabel.Text = "Ответ:";
                MainQuestionLB.Font = new Font("Calibri", 18F);
                MainQuestionLB.ForeColor = Color.Black;
                VariantLB.Font = new Font("Calibri", 18F);
                VariantLB.ForeColor = Color.Black;
                next.Text = "Далеe";
                CurrentQuestionIndex++;
                if (CurrentQuestionIndex < Questions.Length - 1)
                {
                    if (Answer.Text == Questions[CurrentQuestionIndex].Answer)
                        Score++;
                    ShowCurrentQuestionAnswer();
                }
            }
        }
        //овердрайв закрытия
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); // Завершаем приложение после закрытия TestFrame
        }
    }
}
