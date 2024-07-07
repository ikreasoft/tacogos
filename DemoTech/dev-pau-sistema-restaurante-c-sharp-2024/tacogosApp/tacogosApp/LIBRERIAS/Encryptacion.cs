using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.Xml;

// Proyecto de aprendizaje de C# 
// Desarrollo de un sistema de ventas en C# para escritorio usando MSSQL y Report Design R1
// Author: @pauchino09 
// Date: 2024.04.28
namespace tacogosApp.LIBRERIAS
{
    class AES
    {
        // Declaración del constructor de encriptación de datos
        private byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream memorystream = new MemoryStream();
            RijndaelManaged alg = new();
            //g.Mode = CipherMode.CBC;
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cryptostream = new CryptoStream(memorystream, alg.CreateEncryptor(), CryptoStreamMode.Write);
            cryptostream.Write(clearData, 0, clearData.Length);
            cryptostream.Close();
            byte[] encryptedData = memorystream.ToArray();
            return encryptedData;
        }
        //
        public string Encrypt(string Data, string Passwd, int Bits)
        {
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(Data);
            PasswordDeriveBytes passwordderivedbytes = new PasswordDeriveBytes(Passwd, new byte[] { 0x0, 0x1, 0x1C, 0x1D, 0x1E, 0x3, 0x4, 0x5, 0xF, 0x20, 0x21, 0xAD, 0xAF, 0xA4 });
            if ( Bits == 128 )
            {
                byte[] encryptedData = Encrypt(clearBytes, passwordderivedbytes.GetBytes(16), passwordderivedbytes.GetBytes(16));
                return Convert.ToBase64String(encryptedData);
            }
            else if ( Bits == 192 )
            {
                byte[] encryptedData = Encrypt(clearBytes, passwordderivedbytes.GetBytes(24), passwordderivedbytes.GetBytes(16));
                return Convert.ToBase64String(encryptedData);
            }
            else if ( Bits == 256 )
            {
                byte[] encryptedData = Encrypt(clearBytes, passwordderivedbytes.GetBytes(32), passwordderivedbytes.GetBytes(16));
                return Convert.ToBase64String(encryptedData);
            }
            else
            {
                return String.Concat(Bits);
            }
        }

        private byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream memorystream = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cryptostream = new CryptoStream(memorystream, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cryptostream.Write(cipherData, 0, cipherData.Length);
            cryptostream.Close();
            byte[] decryptedData = memorystream.ToArray();
            return decryptedData;
        }

        public string  Decrypt(string Data, string Passwd , int Bits )
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(Data);
                PasswordDeriveBytes passwordderivedbytes = new PasswordDeriveBytes( Passwd, new byte[] { 0x0, 0x1, 0x2, 0x1C, 0x1D, 0x1E, 0x3, 0x4, 0x5, 0xF, 0x20, 0x21, 0xAD, 0xAF, 0xA4 });
                if ( Bits == 128 )
                {
                    byte[] decryptedData = Decrypt(cipherBytes, passwordderivedbytes.GetBytes(16), passwordderivedbytes.GetBytes(16));
                    return System.Text.Encoding.Unicode.GetString(decryptedData);
                }
                else if ( Bits == 192 )
                {
                    byte[] decryptedData = Decrypt(cipherBytes, passwordderivedbytes.GetBytes(24), passwordderivedbytes.GetBytes(16));
                    return System.Text.Encoding.Unicode.GetString(decryptedData);
                }
                else if (Bits == 256)
                {
                    byte[] decryptedData = Decrypt(cipherBytes, passwordderivedbytes.GetBytes(32), passwordderivedbytes.GetBytes(16));
                    return System.Text.Encoding.Unicode.GetString(decryptedData);
                }
                else
                {
                    return String.Concat(Bits);
                }
            } catch ( Exception ex )
            {
                System.Console.WriteLine( ex.Message );
                return String.Concat(Bits);
            }
        }
    }
}
