namespace KeystageOneGUI
{
    partial class WebBrowserHistoryForm
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
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.DeleteHistoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.Location = new System.Drawing.Point(6, 15);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(440, 381);
            this.HistoryListBox.TabIndex = 0;
            // 
            // DeleteHistoryBtn
            // 
            this.DeleteHistoryBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteHistoryBtn.Location = new System.Drawing.Point(357, 402);
            this.DeleteHistoryBtn.Name = "DeleteHistoryBtn";
            this.DeleteHistoryBtn.Size = new System.Drawing.Size(75, 34);
            this.DeleteHistoryBtn.TabIndex = 1;
            this.DeleteHistoryBtn.Text = "Delete History";
            this.DeleteHistoryBtn.UseVisualStyleBackColor = true;
            this.DeleteHistoryBtn.Click += new System.EventHandler(this.DeleteHistoryBtn_Click);
            // 
            // WebBrowserHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(452, 443);
            this.Controls.Add(this.DeleteHistoryBtn);
            this.Controls.Add(this.HistoryListBox);
            this.Name = "WebBrowserHistoryForm";
            this.Text = "WebBrowserHistoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.Button DeleteHistoryBtn;
    }
}