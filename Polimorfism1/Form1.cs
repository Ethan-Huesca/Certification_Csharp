using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfism1
{
    public partial class Form1 : Form
    {
        Calculator cal;
        Pet pe = new Cat("sweet child");
        Pet pe2 = new Bird("o mine");
        List1<string> lista; //Set as public so other classes can have access

        public Form1()
        {
            InitializeComponent();
            cal = new Calculator(23.5, 5.78);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double r = cal.Addition(1, 45.5); //use of one method
            double r2 = cal.Addition(45.5); //use of another method
            double r3 = cal.Addition(3, 6, 9); //use of another method
            MessageBox.Show("r1: "+r.ToString() + " r2: "+ r2.ToString()+ " r3: "+r3.ToString());
            MessageBox.Show(pe.Salute());
            MessageBox.Show(pe2.Salute());

            lista = new List1<string>(10);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            lista.AddElement(txtBoxElement.Text, 0); //Add the element from the textbox on position 0

        }

        private void btnGetElement_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lista.GetElement(0));
        }
    }
}
