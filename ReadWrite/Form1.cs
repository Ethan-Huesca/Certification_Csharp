using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadWrite
{
    public partial class Form1 : Form
    {
        string route = Application.StartupPath + @"\file.xml.txt"; //returns the route in which the program is saved
        //string route = Application.StartupPath + @"\file2.xlsx"; //returns the route in which the program is saved
        string route2 = Application.StartupPath + @"\file2.txt"; //returns the route in which the program is saved

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(route);
            //Stream st = File.OpenRead(route); //It will open the file
            //BufferedStream buf = new BufferedStream(st);
            //byte[] b = new byte[128];
            //buf.Read(b, 0, 128);

            //MessageBox.Show("Array contains :" + Encoding.ASCII.GetString(b)); //display what the file contains

            //Stream st2 = File.OpenRead(route2); //It will open the file
            //BufferedStream buf2 = new BufferedStream(st2);
            //byte[] b2 = new byte[128];
            //buf2.Read(b2, 0, 128);
            //StreamWriter wri = new StreamWriter(route2); //streamwriter to write on a file & creates if it doesnt exist
            //wri.Write("hello again ..."); //text to write on the file
            //wri.Close(); //CLose the file

            StreamReader re = new StreamReader(route);
            textBox1.Text = re.ReadToEnd();
            re.Close();
        }
    }
}
