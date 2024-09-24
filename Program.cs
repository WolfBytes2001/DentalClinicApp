using DentalClinicApp.Forms;

namespace DentalClinicApp
{
    internal static class Program
    {   public static bool isLogin = false;
        public static Login login1 = new Login();
        public static Dashboard dashboard = new Dashboard();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            Application.Run(login1);
          
           
        }
    }
}