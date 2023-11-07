namespace Formularios
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormLogin());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new FormLogin();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                FormCRUD formCRUD = new FormCRUD(login.Usuario);
                formCRUD.Show();
                formCRUD.TopMost = true;
                Application.Run(formCRUD);

            }
            else
            {
                Application.Exit();
            }
        }
    }
}