using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Application1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void DelegateChangeProgress(int val);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangeProgress(int val)
        {
            if (this.InvokeRequired) //if its true, the thread is calling the progress bar
            {
                DelegateChangeProgress delegated = new DelegateChangeProgress(ChangeProgress);
                object[] parameters = new object[] { val }; //Instantiate parameters array
                this.Invoke(delegated, parameters); //send parameters through invoke
            }
            else
            {
                progressBar1.Value = val; //Set the value to the progress bar
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(RunProgress)); //Declare a thread in which the other process runs
            thread1.Start(); //Start running thread1 object declared previously
        }
        private void RunProgress()
        {
            //CheckForIllegalCrossThreadCalls = false; //prevents an exception from happening cuz multithread is executing
            
            for(int i=1; i <= progressBar1.Maximum; i++)
            {
                Thread.Sleep(1000); //sleep 1sec to allow multithread execution
                ChangeProgress(i); //send value to the progress bar
            }
            Console.WriteLine("process done");
        }

        //This process will be executed on background
        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("message!!");
        }
    }
}
