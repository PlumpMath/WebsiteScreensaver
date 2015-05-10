using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SamaritanScreenSaver
{
    static class Program
    {
        private static List<ScreenSaverForm> ScrSaverList;
        public static bool PreviewMode = false;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ScrSaverList = new List<ScreenSaverForm>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon.
                // Examples: /c:1234567 or /P:1234567
                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                    secondArgument = args[1];

                if (firstArgument == "/c")           // Configuration mode
                {
                    Application.Run(new Settings());
                }
                else if (firstArgument == "/p")      // Preview mode
                {
                    PreviewMode = true;
                    if (secondArgument == null)
                    {
                        MessageBox.Show("Sorry, but the expected window handle was not provided.",
                            "ScreenSaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    IntPtr previewWndHandle = new IntPtr(long.Parse(secondArgument));
                    Application.Run(new ScreenSaverForm(previewWndHandle));

                }
                else if (firstArgument == "/s")      // Full-screen mode
                {
                    ShowScreenSaver();
                    Application.Run();
                }
                else    // Undefined argument - treat like /c
                {
                    Application.Run(new Settings());
                }
            }
            else    // No arguments - treat like /c
            {
                Application.Run(new Settings());
            }   
        }

        public static void Exit()
        {
            foreach (ScreenSaverForm scr in ScrSaverList) scr.Close();
            Application.Exit();
        }

        private static void ShowScreenSaver()
        {
            foreach (ScreenSaverForm scr in ScrSaverList) scr.Close();
            ScrSaverList.Clear();


            foreach (Screen screen in Screen.AllScreens)
            {
                ScreenSaverForm scr = new ScreenSaverForm(screen.Bounds);

                scr.isPrimary = screen == Screen.PrimaryScreen;

                scr.Show();
                ScrSaverList.Add(scr);
            }

            foreach (ScreenSaverForm scr in ScrSaverList.Where(s => s.isPrimary)) scr.Capture = true;
        }
    }
}
