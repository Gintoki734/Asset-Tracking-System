namespace Asset_Tracking_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DialogResult result;
            using (var loginForm = new Login())
            {
                result = loginForm.ShowDialog();
            }

            if (result == DialogResult.OK)
            {

                Application.Run(new Form1());
            }
        }
    }
}