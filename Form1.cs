using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Awesomium.Core;
using Awesomium.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace SamaritanScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);


        private TimeSpan openTime;
        public bool isPrimary;

        private bool hasTimeout()
        {
            return (TimeSpan.FromTicks(DateTime.UtcNow.Ticks) - openTime).TotalSeconds > 5;
        }

        private void LoadSettings()
        {
            // Get the value stored in the Registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\WebsiteScreenSaver");
            if (key == null)
                Browser.Source = new Uri("http://rodrigograca31.github.io/Samaritan/?msg=What%20are%20your%20commands%20?");
            else
                Browser.Source = new Uri((string)key.GetValue("text"));
        }

        void wb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (hasTimeout() && (!Program.PreviewMode)) Program.Exit();
        }

        public ScreenSaverForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        public ScreenSaverForm(Rectangle bounds)
        {
            InitializeComponent();
            this.Bounds = bounds;
            LoadSettings();
        }

        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            SetParent(this.Handle, PreviewWndHandle);

            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            LoadSettings();
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            if (Program.PreviewMode) return;

            Cursor.Hide();
            TopMost = true;
            openTime = TimeSpan.FromTicks(DateTime.UtcNow.Ticks);

            Browser.ProcessInput = ViewInput.None;
        }
    }
}
