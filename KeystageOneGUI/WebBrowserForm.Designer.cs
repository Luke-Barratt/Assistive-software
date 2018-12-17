namespace KeystageOneGUI
{
    partial class WebBrowserForm
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
            this.URLTxtBox = new System.Windows.Forms.TextBox();
            this.PreviousPageBtn = new System.Windows.Forms.Button();
            this.ForwardPageBtn = new System.Windows.Forms.Button();
            this.GoToHomeBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RefreshPageBtn = new System.Windows.Forms.Button();
            this.SetNewHomePageBtn = new System.Windows.Forms.Button();
            this.DisplayHistoryBtn = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // URLTxtBox
            // 
            this.URLTxtBox.Location = new System.Drawing.Point(317, 12);
            this.URLTxtBox.Name = "URLTxtBox";
            this.URLTxtBox.Size = new System.Drawing.Size(630, 20);
            this.URLTxtBox.TabIndex = 0;
            // 
            // PreviousPageBtn
            // 
            this.PreviousPageBtn.Location = new System.Drawing.Point(12, 5);
            this.PreviousPageBtn.Name = "PreviousPageBtn";
            this.PreviousPageBtn.Size = new System.Drawing.Size(68, 32);
            this.PreviousPageBtn.TabIndex = 1;
            this.PreviousPageBtn.Text = "<<";
            this.PreviousPageBtn.UseVisualStyleBackColor = true;
            this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
            // 
            // ForwardPageBtn
            // 
            this.ForwardPageBtn.Location = new System.Drawing.Point(86, 5);
            this.ForwardPageBtn.Name = "ForwardPageBtn";
            this.ForwardPageBtn.Size = new System.Drawing.Size(68, 32);
            this.ForwardPageBtn.TabIndex = 2;
            this.ForwardPageBtn.Text = ">>";
            this.ForwardPageBtn.UseVisualStyleBackColor = true;
            this.ForwardPageBtn.Click += new System.EventHandler(this.ForwardPageBtn_Click);
            // 
            // GoToHomeBtn
            // 
            this.GoToHomeBtn.Location = new System.Drawing.Point(234, 5);
            this.GoToHomeBtn.Name = "GoToHomeBtn";
            this.GoToHomeBtn.Size = new System.Drawing.Size(68, 32);
            this.GoToHomeBtn.TabIndex = 3;
            this.GoToHomeBtn.Text = "Home";
            this.GoToHomeBtn.UseVisualStyleBackColor = true;
            this.GoToHomeBtn.Click += new System.EventHandler(this.GoToHomeBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(963, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(68, 32);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RefreshPageBtn
            // 
            this.RefreshPageBtn.Location = new System.Drawing.Point(160, 5);
            this.RefreshPageBtn.Name = "RefreshPageBtn";
            this.RefreshPageBtn.Size = new System.Drawing.Size(68, 32);
            this.RefreshPageBtn.TabIndex = 5;
            this.RefreshPageBtn.Text = "Refresh";
            this.RefreshPageBtn.UseVisualStyleBackColor = true;
            this.RefreshPageBtn.Click += new System.EventHandler(this.RefreshPageBtn_Click);
            // 
            // SetNewHomePageBtn
            // 
            this.SetNewHomePageBtn.Location = new System.Drawing.Point(1037, 5);
            this.SetNewHomePageBtn.Name = "SetNewHomePageBtn";
            this.SetNewHomePageBtn.Size = new System.Drawing.Size(68, 32);
            this.SetNewHomePageBtn.TabIndex = 6;
            this.SetNewHomePageBtn.Text = "Set Home";
            this.SetNewHomePageBtn.UseVisualStyleBackColor = true;
            this.SetNewHomePageBtn.Click += new System.EventHandler(this.SetNewHomePageBtn_Click);
            // 
            // DisplayHistoryBtn
            // 
            this.DisplayHistoryBtn.Location = new System.Drawing.Point(1111, 5);
            this.DisplayHistoryBtn.Name = "DisplayHistoryBtn";
            this.DisplayHistoryBtn.Size = new System.Drawing.Size(68, 32);
            this.DisplayHistoryBtn.TabIndex = 7;
            this.DisplayHistoryBtn.Text = "History";
            this.DisplayHistoryBtn.UseVisualStyleBackColor = true;
            this.DisplayHistoryBtn.Click += new System.EventHandler(this.DisplayHistoryBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(14, 50);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1164, 780);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // WebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 840);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.DisplayHistoryBtn);
            this.Controls.Add(this.SetNewHomePageBtn);
            this.Controls.Add(this.RefreshPageBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.GoToHomeBtn);
            this.Controls.Add(this.ForwardPageBtn);
            this.Controls.Add(this.PreviousPageBtn);
            this.Controls.Add(this.URLTxtBox);
            this.Name = "WebBrowserForm";
            this.Text = "Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTxtBox;
        private System.Windows.Forms.Button PreviousPageBtn;
        private System.Windows.Forms.Button ForwardPageBtn;
        private System.Windows.Forms.Button GoToHomeBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button RefreshPageBtn;
        private System.Windows.Forms.Button SetNewHomePageBtn;
        private System.Windows.Forms.Button DisplayHistoryBtn;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}