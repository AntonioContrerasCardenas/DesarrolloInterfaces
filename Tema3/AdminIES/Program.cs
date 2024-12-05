

using AdminIES.frm;

namespace AdminIES
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmEstudiante());
=======
            Application.Run(new Form1());
>>>>>>> 32dc60a0f5b7edb16280f58c55f7d892ad83c8c3
        }
    }
}