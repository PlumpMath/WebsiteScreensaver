namespace SamaritanScreenSaver
{
    partial class ScreenSaverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Browser = new Awesomium.Windows.Forms.WebControl(this.components);
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.IsTransparent = true;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.NavigationInfo = Awesomium.Core.NavigationInfo.None;
            this.Browser.ProcessInput = Awesomium.Core.ViewInput.Mouse;
            this.Browser.Size = new System.Drawing.Size(1280, 720);
            this.Browser.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.Browser.TabIndex = 0;
            this.Browser.ViewType = Awesomium.Core.WebViewType.Offscreen;
            this.Browser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wb_KeyPress);
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Screen Saver";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wb_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl Browser;
    }
}

