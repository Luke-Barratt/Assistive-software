using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystageOneGUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void WebBrowserBtn_Click(object sender, EventArgs e)
        {
            WebBrowserForm webBrowserForm = new WebBrowserForm();
            webBrowserForm.ShowDialog();
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {

        }

        private void WritingToolbtn_Click(object sender, EventArgs e)
        {
            TextEditorForm textEditorForm = new TextEditorForm();
            textEditorForm.ShowDialog();
        }
    }
}
