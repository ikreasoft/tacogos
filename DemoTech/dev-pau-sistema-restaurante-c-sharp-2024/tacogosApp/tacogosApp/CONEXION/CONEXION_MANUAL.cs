using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace tacogosApp.CONEXION
{
    public partial class CONEXION_MANUAL : Form
    {
        // Referencia a la encriptacion y desencriptacion de los datos transmitidos
        private LIBRERIAS.AES conexionEncriptada = new LIBRERIAS.AES();
        string dbcnString;
        private string XML_FILE_CADENA_CONEXION = "ConnectionString.xml";

        public CONEXION_MANUAL()
        {
            InitializeComponent();
        }

        public void SaveToXML(Object dbcnString)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XML_FILE_CADENA_CONEXION);
                XmlElement root = xmlDoc.DocumentElement;
                root.Attributes[0].Value = Convert.ToString(dbcnString);
                XmlTextWriter xmlWriter = new XmlTextWriter(XML_FILE_CADENA_CONEXION, null);
                xmlWriter.Formatting = Formatting.Indented;
                xmlDoc.Save(xmlWriter);
                xmlWriter.Close();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ReadfromXML()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XML_FILE_CADENA_CONEXION);
                XmlElement root = xmlDoc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                // Textbox de mi formularaio
                txtCnString.Text = (conexionEncriptada.Decrypt(dbcnString, LIBRERIAS.Desencryptacion.appPwdUnique, int.Parse("256")));
            } catch ( System.Security.Cryptography.CryptographicException e )
            {
                Console.WriteLine(e);
            }
        }

        private void CONEXION_MANUAL_Load(object sender, EventArgs e)
        {
            ReadfromXML();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveToXML(conexionEncriptada.Encrypt(txtCnString.Text, LIBRERIAS.Desencryptacion.appPwdUnique, int.Parse("256")));
        }
    }
}
