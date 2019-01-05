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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserForm));
            this.URLTxtBox = new System.Windows.Forms.TextBox();
            this.PreviousPageBtn = new System.Windows.Forms.Button();
            this.ForwardPageBtn = new System.Windows.Forms.Button();
            this.GoToHomeBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RefreshPageBtn = new System.Windows.Forms.Button();
            this.SetNewHomePageBtn = new System.Windows.Forms.Button();
            this.DisplayHistoryBtn = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.BackBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FowardBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RefreshBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HomeBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SetHomeBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HistoryBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URLTxtBox
            // 
            this.URLTxtBox.Location = new System.Drawing.Point(204, 36);
            this.URLTxtBox.Name = "URLTxtBox";
            this.URLTxtBox.Size = new System.Drawing.Size(912, 20);
            this.URLTxtBox.TabIndex = 0;
            this.URLTxtBox.Text = "www.";
            // 
            // PreviousPageBtn
            // 
            this.PreviousPageBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("PreviousPageBtn.Image")));
            this.PreviousPageBtn.Location = new System.Drawing.Point(14, 29);
            this.PreviousPageBtn.Name = "PreviousPageBtn";
            this.PreviousPageBtn.Size = new System.Drawing.Size(40, 32);
            this.PreviousPageBtn.TabIndex = 1;
            this.BackBtnToolTip.SetToolTip(this.PreviousPageBtn, "Click here to go back to the previous website");
            this.PreviousPageBtn.UseVisualStyleBackColor = true;
            this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
            // 
            // ForwardPageBtn
            // 
            this.ForwardPageBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("ForwardPageBtn.Image")));
            this.ForwardPageBtn.Location = new System.Drawing.Point(60, 29);
            this.ForwardPageBtn.Name = "ForwardPageBtn";
            this.ForwardPageBtn.Size = new System.Drawing.Size(42, 32);
            this.ForwardPageBtn.TabIndex = 2;
            this.FowardBtnToolTip.SetToolTip(this.ForwardPageBtn, "Click here to go foward to the next website");
            this.ForwardPageBtn.UseVisualStyleBackColor = true;
            this.ForwardPageBtn.Click += new System.EventHandler(this.ForwardPageBtn_Click);
            // 
            // GoToHomeBtn
            // 
            this.GoToHomeBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("GoToHomeBtn.Image")));
            this.GoToHomeBtn.Location = new System.Drawing.Point(156, 29);
            this.GoToHomeBtn.Name = "GoToHomeBtn";
            this.GoToHomeBtn.Size = new System.Drawing.Size(42, 32);
            this.GoToHomeBtn.TabIndex = 3;
            this.HomeBtnToolTip.SetToolTip(this.GoToHomeBtn, "Click here to go to home page");
            this.GoToHomeBtn.UseVisualStyleBackColor = true;
            this.GoToHomeBtn.Click += new System.EventHandler(this.GoToHomeBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(1122, 29);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(42, 32);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtnToolTip.SetToolTip(this.SearchBtn, "Click here to go to website in the search bar");
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RefreshPageBtn
            // 
            this.RefreshPageBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshPageBtn.Image")));
            this.RefreshPageBtn.Location = new System.Drawing.Point(108, 29);
            this.RefreshPageBtn.Name = "RefreshPageBtn";
            this.RefreshPageBtn.Size = new System.Drawing.Size(42, 32);
            this.RefreshPageBtn.TabIndex = 5;
            this.RefreshBtnToolTip.SetToolTip(this.RefreshPageBtn, "Click here to refresh the current website");
            this.RefreshPageBtn.UseVisualStyleBackColor = true;
            this.RefreshPageBtn.Click += new System.EventHandler(this.RefreshPageBtn_Click);
            // 
            // SetNewHomePageBtn
            // 
            this.SetNewHomePageBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNewHomePageBtn.Image = ((System.Drawing.Image)(resources.GetObject("SetNewHomePageBtn.Image")));
            this.SetNewHomePageBtn.Location = new System.Drawing.Point(1170, 29);
            this.SetNewHomePageBtn.Name = "SetNewHomePageBtn";
            this.SetNewHomePageBtn.Size = new System.Drawing.Size(42, 32);
            this.SetNewHomePageBtn.TabIndex = 6;
            this.SetHomeBtnToolTip.SetToolTip(this.SetNewHomePageBtn, "Click here to set current website as home page");
            this.SetNewHomePageBtn.UseVisualStyleBackColor = true;
            this.SetNewHomePageBtn.Click += new System.EventHandler(this.SetNewHomePageBtn_Click);
            // 
            // DisplayHistoryBtn
            // 
            this.DisplayHistoryBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayHistoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("DisplayHistoryBtn.Image")));
            this.DisplayHistoryBtn.Location = new System.Drawing.Point(1218, 29);
            this.DisplayHistoryBtn.Name = "DisplayHistoryBtn";
            this.DisplayHistoryBtn.Size = new System.Drawing.Size(42, 32);
            this.DisplayHistoryBtn.TabIndex = 7;
            this.HistoryBtnToolTip.SetToolTip(this.DisplayHistoryBtn, "Click here to access a list of websites previously visited");
            this.DisplayHistoryBtn.UseVisualStyleBackColor = true;
            this.DisplayHistoryBtn.Click += new System.EventHandler(this.DisplayHistoryBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(14, 67);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1246, 780);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter a website in the search bar below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Move mouse over the buttons to see what they do";
            // 
            // WebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1270, 854);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.ToolTip BackBtnToolTip;
        private System.Windows.Forms.ToolTip FowardBtnToolTip;
        private System.Windows.Forms.ToolTip RefreshBtnToolTip;
        private System.Windows.Forms.ToolTip HomeBtnToolTip;
        private System.Windows.Forms.ToolTip SearchBtnToolTip;
        private System.Windows.Forms.ToolTip SetHomeBtnToolTip;
        private System.Windows.Forms.ToolTip HistoryBtnToolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}