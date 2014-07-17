using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;


namespace web_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
     

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            button4.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            webBrowser1.Navigate("www.google.com");
            textBox1.Text = "www.google.com";
            //button4.Text = DateTime.Now.ToString();
           
        }

     

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar1.Value = (int)e.CurrentProgress;
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            toolStripStatusLabel1.Text = " Done ";
            toolStripStatusLabel1.BackColor = Color.Red;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
       
        

       
    }
}