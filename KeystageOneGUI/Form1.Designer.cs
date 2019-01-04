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
            this.TextEditorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebBrowserBtn
            // 
            this.WebBrowserBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CalculatorBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculatorBtn.Location = new System.Drawing.Point(180, 75);
            this.CalculatorBtn.Name = "CalculatorBtn";
            this.CalculatorBtn.Size = new System.Drawing.Size(162, 82);
            this.CalculatorBtn.TabIndex = 1;
            this.CalculatorBtn.Text = "Calculator";
            this.CalculatorBtn.UseVisualStyleBackColor = true;
            this.CalculatorBtn.Click += new System.EventHandler(this.CalculatorBtn_Click);
            // 
            // TextEditorBtn
            // 
            this.TextEditorBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEditorBtn.Location = new System.Drawing.Point(348, 75);
            this.TextEditorBtn.Name = "TextEditorBtn";
            this.TextEditorBtn.Size = new System.Drawing.Size(162, 82);
            this.TextEditorBtn.TabIndex = 2;
            this.TextEditorBtn.Text = "Write";
            this.TextEditorBtn.UseVisualStyleBackColor = true;
            this.TextEditorBtn.Click += new System.EventHandler(this.WritingToolbtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(538, 226);
            this.Controls.Add(this.TextEditorBtn);
            this.Controls.Add(this.CalculatorBtn);
            this.Controls.Add(this.WebBrowserBtn);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WebBrowserBtn;
        private System.Windows.Forms.Button CalculatorBtn;
        private System.Windows.Forms.Button TextEditorBtn;
    }
}

