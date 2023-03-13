using Microsoft.Win32;

namespace Chezz_Puzzler
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
            Application.Run(new Form_base());
        }
        public static bool isAssociated()
        {
            //  return Registry.CurrentUser.OpenSubKey("Software\\Classes\\.pzq",false) = null));
            return true;
        }
        public static void Associate()
        {
            RegistryKey fileReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\.pzq");
            RegistryKey AppReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\PuzzQ.exe");
            RegistryKey AppAssoc = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.pzq");
            string here = Application.StartupPath + "chessicon.ico";
            fileReg.CreateSubKey("DefaultIcon").SetValue("icon",here);
        }
            
    }
}