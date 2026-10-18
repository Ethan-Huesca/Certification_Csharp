using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembled = Assembly.LoadFile(Application.StartupPath + "\\Library2.dll"); //returns the path of the file
            Type[] types = assembled.GetTypes(); //Save all the types of files in an array
            foreach(Type type in types)
            {
                if(type.IsClass) //Evaluates if it is class type
                    lstClasses.Items.Add(type.Name);
            }

            FieldInfo[] attributes = types[0].GetFields(); //create array to save first class attributes, in this example
            foreach(FieldInfo field in attributes)
            {
                lstAttributes.Items.Add(field.Name); //add attributes to the list
            }

            MethodInfo[] methods = types[0].GetMethods(); //Returns all methods and stores them into array, from first class in this example
            foreach(MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.Name); //add methods to the list
            }

            string[] names = new string[] { "name1" };
            object obj = Activator.CreateInstance(types[0], names); //variable to save instance of a class, first class in this example
            object[] parameters = null; //object as an array to enable future receivement of multiple parameters
            methods[0].Invoke(obj, parameters); //invoke the method from the methods array, with the specified parameters

            Type type1 = Type.GetType("System.String");
            DateTime date = DateTime.Now;
            Type tip = date.GetType();
        }
    }
}
