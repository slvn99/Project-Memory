﻿using System;
using System.IO;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using Memory.Properties;
using System.Security.Cryptography;
using System.Text;


namespace WindowsFormsApp1
{
    /// <summary>
    /// het opslaan van de gamestate, samen met encryptie
    /// </summary>
    [Serializable]
    public class Save
    {
        public static int lengte = 0 ;

        //-------------------------------------------------------------------------------//
        //Caller write
        public static void SaveData(string player1, string player2, int score1, int score2, string playerbeurt, int matches, string[] matcharray, int lengteimport)
        {
            //hier benoem ik path tot de locatie van de .exe
            var path = AppDomain.CurrentDomain.BaseDirectory;

            //omzetten naar bytes
            byte[] serialized = Serialize(player1, player2, score1, score2, playerbeurt, matches, matcharray, lengteimport);

            //deze bytes writen
            WriteToFile(@"" + path + "game.sav", serialized);

            Encrypt();

        }
       

        //Caller read
        public static string LoadData()
        {
            //hier benoem ik path tot de locatie van de .exe
            var path = AppDomain.CurrentDomain.BaseDirectory;

            Decrypt();

            //het ophalen van de bytes uit de .sav
            byte[] bytes = ReadFromFile(@""+ path + "game.sav");

            //Terugzetten van bytes naar data
            string opslag = Deserialize(bytes);

            //weer encrypten
            Save.Encrypt();
            //variabelen teruggeven aan button die een label aanpast
            return (opslag);           
        }

        

        //------------------------------------------------------------------------------//
        //Methods
        public static byte[] Serialize(string player1, string player2, int score1, int score2, string playerbeurt, int matches, string[] matcharray, int lengte)
        {
            //Nieuwe memory stream aanmaken die wordt gebruikt door de formatter
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            using (MemoryStream stream = new MemoryStream())
            {
                //Binary formatter die de data serialized, en dit in de stream zet
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, lengte);
                formatter.Serialize(stream, player1);
                formatter.Serialize(stream, player2);
                formatter.Serialize(stream, score1);
                formatter.Serialize(stream, score2);
                formatter.Serialize(stream, playerbeurt);
                formatter.Serialize(stream, matches);

                int i = 0;
                
                while(i < lengte)
                {
                    formatter.Serialize(stream, matcharray[i]);
                    i++;
                }

                //Return
                return stream.ToArray();
            }
        }

        private static string Deserialize(byte[] data)
        {
            string buf1, buf2, buf3, buf4, buf5, buf6,buf8, opslag = "";

            //Nieuwe memory stream aanmaken die wordt gebruikt door de formatter
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            //De data uit de .sav wordt in de stream gezet
            try
            {
                using (MemoryStream stream = new MemoryStream(data))
                {
                    //Binary formatter die de data deserialized, en dit in de stream zet
                    BinaryFormatter formatter = new BinaryFormatter();

                    //load het getal welke aangeeft hoeveel entry's de array had
                    var l = formatter.Deserialize(stream);
                    string l1 = Convert.ToString(l);
                    int l2 = int.Parse(l1);

                    //Return de game data.
                    var d1 = formatter.Deserialize(stream);
                    var d2 = formatter.Deserialize(stream);
                    var d3 = formatter.Deserialize(stream);
                    var d4 = formatter.Deserialize(stream);
                    var d5 = formatter.Deserialize(stream);
                    var d6 = formatter.Deserialize(stream);
                   
                    buf1 = Convert.ToString(d1);
                    buf2 = Convert.ToString(d2);
                    buf3 = Convert.ToString(d3);
                    buf4 = Convert.ToString(d4);
                    buf5 = Convert.ToString(d5);
                    buf6 = Convert.ToString(d6);
                    buf8 = l1;
               
                    opslag = (buf1 + "\n" + buf2 + "\n" + buf3 + "\n" + buf4 + "\n" + buf5 + "\n" + buf6+"\n"+buf8);

                    int i = 0;
                    while (i < l2)
                    {
                        var d7 = formatter.Deserialize(stream);
                        string buf7 = Convert.ToString(d7);
                        opslag = (opslag + "\n" + buf7);
                        i++;
                    }

                    return opslag;
                }
            }
            catch (ArgumentNullException)
            {
                string message = "Er is nog geen\nsave file\naanwezig";
                return message;
            }
        }

        private static void WriteToFile(string file, byte[] data)
        {
            //Try catch block om eventuele errors af te vangen.
            try
            {
                //Schrijf all bytes naar het opgegeven path.
                File.WriteAllBytes(file, data);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not write file due: " + e.Message);
            }
        }

        private static byte[] ReadFromFile(string file)
        {
            //Try catch block om eventuele errors af te vangen.
            try
            {
                //Alle bytes uitlezen uit een bestand en deze returnen.
                byte[] bytes = File.ReadAllBytes(file);
                return bytes;
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not read file due: " + e.Message);
            }

            return null;
        }

        //encrypt
        public static void Encrypt()
        {
            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                //Create a new instance of the RijndaelManaged class  
                // and encrypt the stream.  
                RijndaelManaged RMCrypto = new RijndaelManaged();

                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] encrypted;
                byte[] raw;
                raw = ReadFromFile(@"" + path + "game.sav");
                string edited = Encoding.ASCII.GetString(raw);

                using (Rijndael rijAlg = Rijndael.Create())
                {

                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = rijAlg.CreateEncryptor(Key, IV);

                    // Create the streams used for encryption.
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                //Write to the stream.  
                                swEncrypt.Write(edited);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }
                WriteToFile(@"" + path + "game.sav", encrypted);
            }
            catch (Exception)
            {
            }
        }

        //decrypt
        public static void Decrypt()
        {
            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                //Create a new instance of the RijndaelManaged class  
                // and encrypt the stream.  
                RijndaelManaged RMCrypto = new RijndaelManaged();

                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                string buffer;

                using (Rijndael rijAlg = Rijndael.Create())
                {

                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform decryptor = rijAlg.CreateDecryptor(Key, IV);
                    byte[] bytes = ReadFromFile(@"" + path + "game.sav");
                    // Create the streams used for encryption.
                    using (MemoryStream msDecrypt = new MemoryStream(bytes))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                buffer = srDecrypt.ReadToEnd();
                                byte[] decrypted = Encoding.ASCII.GetBytes(buffer);
                                WriteToFile(@"" + path + "game.sav", decrypted);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {              
            }
        }

    }
}

       