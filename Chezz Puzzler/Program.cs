using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Chezz_Puzzler
{
    internal static class Program
    {
       // [DllImport("shell32.dll",CharSet =CharSet.Auto,SetLastError =true)]
       // public static extern void ChangeNotify(uint EventID,uint Flags, IntPtr Item1, IntPtr Item2);
        
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_base(""));
            /*if (!isAssociated())
            {
                Associate();
            }
           
           
            
            if (args.Length == 0)
            {
                Application.Run(new Form_base(""));
            }
            else
            {
                Application.Run(new Form_base(args[0]));
            }*/
        }
       /* public static bool isAssociated()
        {
            bool state = Registry.CurrentUser.OpenSubKey("Software\\Classes\\.pzq", false) == null ? true : false ;
            return state;
            
        }
        public static void Associate()
        {
            RegistryKey fileReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\.pzq");
            RegistryKey AppReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\PuzzQ.exe");
            RegistryKey AppAssoc = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.pzq");
            string here = Application.StartupPath + "chessicon.ico";
            fileReg.CreateSubKey("DefaultIcon").SetValue("icon",here);
            fileReg.CreateSubKey("PerceivedType").SetValue("", "Text");
            AppReg.CreateSubKey("shell\\solve\\command").SetValue("","\\"+ Application.ExecutablePath + "\\ %1");
            AppReg.CreateSubKey("shell\\edit\\command").SetValue("","\\" +Application.ExecutablePath + "\\ %1");
            AppReg.CreateSubKey("DefaultIcon").SetValue("",here);
            AppAssoc.CreateSubKey("0x00000000", "0x0000", IntPtr.Zero,IntPtr.Zero);
        }*/
            
    }
}