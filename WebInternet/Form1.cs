using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void textURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                webBrowser.Navigate(textURL.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textURL.Text))
            webBrowser.Navigate(textURL.Text);
        }

        private void btnForward_Click_1(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
    }
}
