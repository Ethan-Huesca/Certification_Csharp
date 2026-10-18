using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace RemoteConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RetreieveData(string url)
        {
            WebClient webClient = new WebClient(); //webclient object to send and get data from a url
            Stream stream =  webClient.OpenRead(url); //stream object to save all the data from the url

            StreamReader reader = new StreamReader(stream); //reader object, reads the whole file
            string answ = reader.ReadToEnd();//reads all characters 
            reader.Close(); //Close connection with url

            richTextBox1.Text = answ; //
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            RetreieveData(textURL.Text); //set url to textbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textURL.Text; //Set text url to label
        }
    }
}
