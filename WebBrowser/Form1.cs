using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = webBrowser1.DocumentTitle;

            label2.Text = webBrowser1.Document.Url.AbsoluteUri;

            listView1.Items.Add(label2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = listView1.SelectedItems[0].SubItems[0].Text;

            webBrowser1.Navigate(label2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
