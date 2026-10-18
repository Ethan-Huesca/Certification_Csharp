using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //Library to enable crypto
namespace CryptoSymmetric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Rijndael cryptoRijn = Rijndael.Create(); //Static class, dont need to instantiate

            byte[] byteEntry = null; //Array for text to encrypt
            byte[] byteExit = null; //Array for encrypted text

            String message = this.txtMessage.Text;
            String password = this.txtKey.Text;
            string result = this.EncryptText(message, (new PasswordDeriveBytes(password, null)).GetBytes(32)); //gets the password and coverts it to 32byte array
            this.txtResult.Text = result; 
        }

        private string EncryptText(string _message, byte[] byteKey)
        {
            Rijndael cyphratedRijn = Rijndael.Create(); //Static class, dont need to instantiate

            byte[] byteEncrypted = null; //Array for text to encrypt
            byte[] byteExit = null; //Array for encrypted text

            try //catch exceptions
            {
                cyphratedRijn.Key = byteKey;
                cyphratedRijn.GenerateIV();
                byte[] byteEntry = System.Text.Encoding.UTF8.GetBytes(_message); //Decode input message and save it on array
                byteEncrypted = cyphratedRijn.CreateEncryptor().TransformFinalBlock(byteEntry, 0, byteEntry.Length);
                byteExit = new byte[cyphratedRijn.IV.Length + byteEncrypted.Length]; //Exit byte will be the sum of cyphrated & encrypted
                cyphratedRijn.IV.CopyTo(byteExit, 0); //copy all elments into the byteexit array
                byteEncrypted.CopyTo(byteExit, cyphratedRijn.IV.Length);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally //for cleaning variables
            {
                cyphratedRijn.Clear();
            }
            string txtExit = Encoding.Default.GetString(byteExit); //Decode byte to save it on string type
            return txtExit;
        }

        private string DecryptText(byte[] byteDataCyphrated, byte[] byteKey) {
            Rijndael cyphratedRijn = Rijndael.Create(); //Static class, dont need to instantiate
            byte[] temporaryArray = new byte[cyphratedRijn.IV.Length]; //array which will temporary save the cyphrated data to decrypt
            byte[] Encryptedbyte = new byte[byteDataCyphrated.Length - cyphratedRijn.IV.Length]; //
            string decyprhedText = string.Empty; //string to savve the decrypted data
            try
            {
                cyphratedRijn.Key = byteKey;
                Array.Copy(byteDataCyphrated, temporaryArray, temporaryArray.Length); //copy cyphrated data into the temporary array
                Array.Copy(byteDataCyphrated, temporaryArray.Length, Encryptedbyte, 0, Encryptedbyte.Length);
                cyphratedRijn.IV = temporaryArray; //set temporary array to symmetric cyprhated algorithm

                //decyprhedText = System.Text.Encoding.UTF8.GetString((cyphratedRijn.CreateDecryptor()).TransformFinalBlock(Encryptedbyte, 0, Encryptedbyte.Length));
                decyprhedText = System.Text.Encoding.UTF8.GetString((cyphratedRijn.CreateDecryptor()).TransformFinalBlock(Encryptedbyte, 0, Encryptedbyte.Length));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                cyphratedRijn.Clear();
            }
            return decyprhedText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedmessage = this.txtResult.Text; //get the encrypted mssg
            string password = this.txtKey.Text; //get the password
            byte[] txtByte; //array for saving the encrypted mssg
            txtByte = Encoding.Default.GetBytes(encryptedmessage); //get the encoded message into bytes
            string result = DecryptText(txtByte, (new PasswordDeriveBytes(password, null)).GetBytes(32)); //send the encoded byte array to decrypttext class
            this.txtMessage.Text = result;
        }
    }
}
