using System;
using System.Windows.Forms;

namespace C_2sem_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            (new log_in()).Show();
            Application.Run();
            // MrRxncor mainP = new MrRxncor();
            // mainP.Hide();
        }
    }
}
