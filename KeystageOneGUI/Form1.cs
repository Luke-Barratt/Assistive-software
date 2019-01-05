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
            // Creates a new web browser instance.
            WebBrowserForm webBrowserForm = new WebBrowserForm();
            // Opens web browser form.
            webBrowserForm.ShowDialog();
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            // Creates a new calculator instance
            CalculatorForm calculatorForm = new CalculatorForm();
            // Opens calculator form.
            calculatorForm.ShowDialog();
        }

        private void WritingToolbtn_Click(object sender, EventArgs e)
        {
            //Creates a new Text Editor instance.
            TextEditorForm textEditorForm = new TextEditorForm();
            // Opens Text Editor form.
            textEditorForm.ShowDialog();
        }
    }
}
