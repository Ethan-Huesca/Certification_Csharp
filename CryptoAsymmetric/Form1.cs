using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace CryptoAsymmetric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            ClassEncryption crypto = new ClassEncryption(); //instantiate the classencryption class
            FolderBrowserDialog f = new FolderBrowserDialog(); //Instantiate class for selecting folder in directory
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String folder = f.SelectedPath; //get the path of the selected folder
                FileStream file = new FileStream(Path.Combine(folder, "PublicKey.xml"), FileMode.Create, FileAccess.Write); //Creation of a new file named publicKey.xml
                byte[] publicKey = crypto.CreatePublicKeys(); //store public keys in array
                file.Write(publicKey, 0, publicKey.Length); //write the publicKey in file
                file.Close(); //close the file
                file = new FileStream(Path.Combine(folder, "PrivateKey.xml"), FileMode.Create, FileAccess.Write); //create new file named privatekey
                byte[] claveprivada = crypto.CreatePrivateKeys(); //store private keys in array
                file.Write(claveprivada, 0, claveprivada.Length); //write the private key in file
                file.Close(); //close the filee
                MessageBox.Show("keys stored successfully");
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //open file dialog
            ofd.Filter = "public keys (*.xml)|*.xml"; //filter by xml type
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if file is selected okay
            {
                Stream temporary = ofd.OpenFile(); //get file and save it temporary variable
                String publicxmlkey = new StreamReader(temporary).ReadToEnd(); //read file content with streamreader
                byte[] encrypteddata = ClassEncryption.EncryptText(this.txtMessage.Text, publicxmlkey); //send file content to encryption class
                this.txtResult.Text = Convert.ToBase64String(encrypteddata); //place the encrypted data into txt box
                this.txtMessage.Clear(); //clear mssg text box
                this.txtMessage.Text = this.txtResult.Text; //set the text in the result box to the mssg box
                this.txtResult.Clear(); //clear the result box
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Open file window
            ofd.Filter = "Private class (*.xml)|*.xml"; //filter 
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if a file was selected okay
            {
                Stream temporary = ofd.OpenFile(); //save file into temporary variable
                String privatexmlkey = new StreamReader(temporary).ReadToEnd(); //read file content
                byte[] decyphreddata = ClassEncryption.DecryptText(this.txtMessage.Text, privatexmlkey); //send to decrypt class
                this.txtResult.Text = Encoding.ASCII.GetString(decyphreddata); //set decyphred data into result txt box
            }
        }
    }
}
