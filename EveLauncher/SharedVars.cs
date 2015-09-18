
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EveLauncher
{
    public static class SharedVars
    {
        public static string eveFolderloc;


        public static void setDefaults()
        {
            eveFolderloc = @"C:\Program Files (x86)\CCP\EVE\";
        }

        public static void throwError(string error)
        {
            MessageBox.Show(error,
                "Critical Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
        }

        public static void launchProc(string path)
        {
            launchProc(path, "");
        }

        public static void launchProc(string path, string args)
        {
            try
            {
                Console.WriteLine("x: " + eveFolderloc + path);
                Process.Start(eveFolderloc + path, args);
            }
            catch (Exception error)
            {
                throwError(error.ToString());
            }
        }

        public static void launchProc(string path, Button button)
        {
            launchProc(path, "", button);
        }

        public static void launchProc(string path, string args, Button button)
        {
            string temp = button.Text;
            button.Text = "loading...";

            launchProc(path, args);

            button.Text = temp;
        }

    }
}
