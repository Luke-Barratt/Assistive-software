using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystageOneGUI
{ 
    public partial class WebBrowserHistoryForm : Form
    {
        public ArrayList HistoryArray { get; set; }

        public WebBrowserHistoryForm()
        {
            InitializeComponent();
        }

        public void setHistory(ArrayList History)
        {
            HistoryListBox.DataSource = History;
        }

        private void DeleteHistoryBtn_Click(object sender, EventArgs e)
        {
            if ((HistoryArray.Count == 0))
            {
                MessageBox.Show("History is empty");
            }
            else
            {
                WebBrowser Form = new WebBrowser();
                HistoryArray.Clear();
                HistoryListBox.DataSource = null;
                HistoryListBox.Items.Clear();
            }
        }
    }
}
