using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.Arm;

namespace tacogosApp.LIBRERIAS
{
    internal class Desencryptacion
    {
        static private Encryptacion aes = new Encryptacion();
        static public string CnString;
        static string dbcnString;
        // Firma personal de des/encriptado del software
        static public string appPwdUnique = "+t%yA&Bfh¿uRKA6CBNohxCiS3^BQv*/XYc@VYjgU9ruS@ÑSg#gkKzHTptLxfj?pCNQE2jNXAg#zvohrPSLN9xtchMvo2sUao9X:Restaurante.Tacogos.BASEREST.Hola_Mundo-Desde_Talavera_España=>";
        
        public static object checkServer()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("ConnectionString.xml");
            XmlElement root = xmlDoc.DocumentElement;
            dbcnString = root.Attributes[0].Value;
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;
        }

        internal class label
        {

        }

        public static object UsuarioEncrypt()
        {
            XmlDocument xmlDoc = new XmlDocument();
            label root = new label();
            dbcnString = root.ToString();
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;
        }
    }
}
