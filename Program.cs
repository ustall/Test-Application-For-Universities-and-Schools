using System;
using System.Windows.Forms;

namespace mgri_tests
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ChooseFrame chooseFrame = new ChooseFrame();
            //TestFrame testFrame = new TestFrame(1);

            //chooseFrame.TestFrameInstance = testFrame; // Передаем ссылку на TestFrame в ChooseFrame

            chooseFrame.Show();
            Application.Run();
        }
    }
}
