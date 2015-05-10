namespace SamaritanScreenSaver
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.WebsiteBox = new System.Windows.Forms.TextBox();
            this.GOBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Browser = new Awesomium.Windows.Forms.WebControl(this.components);
            this.SuspendLayout();
            // 
            // WebsiteBox
            // 
            this.WebsiteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebsiteBox.Location = new System.Drawing.Point(12, 170);
            this.WebsiteBox.Name = "WebsiteBox";
            this.WebsiteBox.Size = new System.Drawing.Size(711, 20);
            this.WebsiteBox.TabIndex = 1;
            this.WebsiteBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WebsiteBox_KeyPress);
            // 
            // GOBtn
            // 
            this.GOBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GOBtn.Location = new System.Drawing.Point(729, 168);
            this.GOBtn.Name = "GOBtn";
            this.GOBtn.Size = new System.Drawing.Size(63, 23);
            this.GOBtn.TabIndex = 2;
            this.GOBtn.Text = "Go";
            this.GOBtn.UseVisualStyleBackColor = true;
            this.GOBtn.Click += new System.EventHandler(this.GOBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Website Screensaver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Browser
            // 
            this.Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Browser.Location = new System.Drawing.Point(12, 196);
            this.Browser.Size = new System.Drawing.Size(780, 439);
            this.Browser.TabIndex = 5;
            this.Browser.ViewType = Awesomium.Core.WebViewType.Offscreen;
            this.Browser.AddressChanged += new Awesomium.Core.UrlEventHandler(this.Awesomium_Windows_Forms_WebControl_AddressChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 647);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GOBtn);
            this.Controls.Add(this.WebsiteBox);
            this.MinimumSize = new System.Drawing.Size(820, 685);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WebsiteBox;
        private System.Windows.Forms.Button GOBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Awesomium.Windows.Forms.WebControl Browser;
    }
}