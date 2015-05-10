using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SamaritanScreenSaver
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();

            Browser.Source = new Uri(Website);
            WebsiteBox.Text = Website;
        }

        public string Website;

        private void LoadSettings()
        {
            // Get the value stored in the Registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\WebsiteScreenSaver");
            if (key == null)
                Website = "http://rodrigograca31.github.io/Samaritan/?msg=What%20are%20your%20commands%20?"; // "https://eyes.nasa.gov/dsn/dsn.html"; // Other cool website to check out
            else
                Website = (string)key.GetValue("text");
        }


        private void SaveSettings()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\WebsiteScreenSaver");

            key.SetValue("text", Website);
        }


        private void GOBtn_Click(object sender, EventArgs e)
        {
            Uri URL;
            if(Uri.TryCreate(WebsiteBox.Text, UriKind.Absolute, out URL) && URL.Scheme == Uri.UriSchemeHttp)
            {
                Website = WebsiteBox.Text;
                Browser.Source = URL;
            }
            else
            {
                Browser.Source = new Uri(String.Format("https://www.google.com/?q={0}",
                                                        WebsiteBox.Text.Replace(" ", "+")));
            }
        }

        private void WebsiteBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
                GOBtn_Click(sender, e);
        }

        private void Awesomium_Windows_Forms_WebControl_AddressChanged(object sender, Awesomium.Core.UrlEventArgs e)
        {
            Website = e.Url.AbsoluteUri.ToString();
            WebsiteBox.Text = Website;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
