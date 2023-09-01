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
           
            if (args.Length > 0 )
            {
                string firstFile = args[0];
             //   MessageBox.Show(firstFile);
                Application.Run(new Form_base(firstFile));
            }
            else
            {
                Application.Run(new Form_base(""));
            }
             
             
        }
    }
}