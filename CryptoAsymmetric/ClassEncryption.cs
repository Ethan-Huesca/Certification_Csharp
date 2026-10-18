using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoAsymmetric
{
    public class ClassEncryption
    {
        public RSACryptoServiceProvider RSA { get; set; } //create attribute with the RSA algorithm, which encrypts & decrypts
        public ClassEncryption()
        {
            this.RSA = new RSACryptoServiceProvider(); //instance of the RSA class
        }
        public byte[] CreatePublicKeys() //byte aray which will contain the xml file content
        {
            String publicxmlkey = this.RSA.ToXmlString(false); //create public xml key setting the event to false
            return Encoding.ASCII.GetBytes(publicxmlkey); //return it as a byte array
        }
        public byte[] CreatePrivateKeys()
        {
            String privatexmlkey = this.RSA.ToXmlString(true); //create private xml key setting the event to true
            return Encoding.ASCII.GetBytes(privatexmlkey); //return it as a byte array
        }

        public static byte[] EncryptText(String message, String publicKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024); //instance class with max bit size
            rsa.FromXmlString(publicKey); //initialize the object of type xml
            byte[] encryptedData = rsa.Encrypt(Encoding.ASCII.GetBytes(message), false); //decode message to encrypt and save in array
            return encryptedData;
        }

        public static byte[] DecryptText(String mensajeencriptado, String privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(privateKey);
            byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(mensajeencriptado), false);
            return decryptedData;
        }
    }
}
