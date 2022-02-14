using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Browser_Project
{
    public partial class Form1 : Form
    {
        string startUrl = "https://www.google.hr";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(startUrl);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //btnBack.Enabled = false;
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
            else
            {
                btnBack.Enabled = false;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //btnForward.Enabled = false;
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
            else
            {
                btnForward.Enabled = false;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(startUrl);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string webUrl = textBox1.Text.Trim();
            webBrowser1.Navigate(webUrl);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}