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
    public partial class WebBrowserForm : Form
    {
        public String HomeURL = "www.google.com";
        public ArrayList HistoryArray = new ArrayList();

        public WebBrowserForm()
        {
            InitializeComponent();
        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(URLTxtBox.Text);
        }
        // When home button is click web browser will navigate to HomeURL.
        private void GoToHomeBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(HomeURL);
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void ForwardPageBtn_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void RefreshPageBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void SetNewHomePageBtn_Click(object sender, EventArgs e)
        {
            HomeURL = URLTxtBox.Text;
            MessageBox.Show("New home page set to: " + URLTxtBox.Text);
        }

        private void DisplayHistoryBtn_Click(object sender, EventArgs e)
        {
            WebBrowserHistoryForm historyForm = new WebBrowserHistoryForm();
            historyForm.setHistory(HistoryArray);
            historyForm.HistoryArray = HistoryArray;
            historyForm.ShowDialog();
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            URLTxtBox.Text = webBrowser.Url.ToString();
            HistoryArray.Add(webBrowser.Url.ToString());
        }
    }
}
