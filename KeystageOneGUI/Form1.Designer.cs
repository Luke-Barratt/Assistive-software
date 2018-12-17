namespace KeystageOneGUI
{
    partial class MainMenuForm
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
            this.WebBrowserBtn = new System.Windows.Forms.Button();
            this.CalculatorBtn = new System.Windows.Forms.Button();
            this.WritingToolbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebBrowserBtn
            // 
            this.WebBrowserBtn.Location = new System.Drawing.Point(12, 75);
            this.WebBrowserBtn.Name = "WebBrowserBtn";
            this.WebBrowserBtn.Size = new System.Drawing.Size(162, 82);
            this.WebBrowserBtn.TabIndex = 0;
            this.WebBrowserBtn.Text = "Web Browser";
            this.WebBrowserBtn.UseVisualStyleBackColor = true;
            this.WebBrowserBtn.Click += new System.EventHandler(this.WebBrowserBtn_Click);
            // 
            // CalculatorBtn
            // 
            this.CalculatorBtn.Location = new System.Drawing.Point(180, 75);
            this.CalculatorBtn.Name = "CalculatorBtn";
            this.CalculatorBtn.Size = new System.Drawing.Size(162, 82);
            this.CalculatorBtn.TabIndex = 1;
            this.CalculatorBtn.Text = "Calculator";
            this.CalculatorBtn.UseVisualStyleBackColor = true;
            this.CalculatorBtn.Click += new System.EventHandler(this.CalculatorBtn_Click);
            // 
            // WritingToolbtn
            // 
            this.WritingToolbtn.Location = new System.Drawing.Point(348, 75);
            this.WritingToolbtn.Name = "WritingToolbtn";
            this.WritingToolbtn.Size = new System.Drawing.Size(162, 82);
            this.WritingToolbtn.TabIndex = 2;
            this.WritingToolbtn.Text = "Write";
            this.WritingToolbtn.UseVisualStyleBackColor = true;
            this.WritingToolbtn.Click += new System.EventHandler(this.WritingToolbtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 224);
            this.Controls.Add(this.WritingToolbtn);
            this.Controls.Add(this.CalculatorBtn);
            this.Controls.Add(this.WebBrowserBtn);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WebBrowserBtn;
        private System.Windows.Forms.Button CalculatorBtn;
        private System.Windows.Forms.Button WritingToolbtn;
    }
}

