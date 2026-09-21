namespace QuanLyQuanCafe_WF
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
            ApplicationConfiguration.Initialize();
            //MessageBox.Show(QuanLyQuanCafe_WinForms.DataAccess.KiemTraKetNoi() ? "Ket noi OK" : "Ket noi FAIL");
            Application.Run(new FormDangNhap());
        }
    }
}