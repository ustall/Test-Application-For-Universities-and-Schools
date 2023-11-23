using System;
using System.Windows.Forms;

namespace mgri_tests
{
    public partial class ChooseFrame : Form
    {
        public TestFrame TestFrameInstance { get; set; }
        public int testId = 0;
        //иниацализация листа тестов
        public ChooseFrame()

        {
            InitializeComponent();
            listBox1.Items.Add("Контрольный тест по теме «Логический анализ языка»");
            listBox1.Items.Add("Контрольный тест по теме «Понятие»");
            listBox1.Items.Add("Контрольный тест по теме «Операции над понятием»");
            listBox1.Items.Add("Обучающий тест на тему: «Суждения»");
            listBox1.Items.Add("Обучающий тест по теме: «Умозаключение»(начало)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testId != 0)
            {
                TestFrame testFrame = new TestFrame(testId);
                testFrame.Show();
                this.Hide();
            }
            else
            {
                string message = $"Пожалуйста выберете тест";
                MessageBox.Show(message, string.Empty, MessageBoxButtons.OK);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            testId = listBox1.SelectedIndex + 1;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); // Завершаем приложение после закрытия TestFrame
        }
    }
}
