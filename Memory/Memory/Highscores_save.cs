using System;
using System.IO;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using Memory.Properties;

namespace Memory
{
    [Serializable]
    class Highscores_save
    {

        //-------------------------------------------------------------------------------//
        //Caller write
        public static void SaveData(string naam, int score, int lengte)
        {
            //hier benoem ik path tot de locatie van de .exe
            var path = AppDomain.CurrentDomain.BaseDirectory;

            string save = LoadData();

            string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            lengte = int.Parse(savearray[0]);
            
            //omzetten naar bytes
            byte[] serialized = Serialize(lengte,savearray);

            //deze bytes writen
            WriteToFile(@"" + path + "highscores.sav", serialized);
        }

        //Caller read
        public static string LoadData()
        {
            //hier benoem ik path tot de locatie van de .exe
            var path = AppDomain.CurrentDomain.BaseDirectory;

            //het ophalen van de bytes uit de .sav
            byte[] bytes = ReadFromFile(@"" + path + "highscores.sav");

            //Terugzetten van bytes naar data
            string opslag = Deserialize(bytes);

            //variabelen teruggeven aan button die een label aanpast
            return (opslag);
        }

        //------------------------------------------------------------------------------//
        //Methods
        public static byte[] Serialize(int lengte, string[]savearray)
        {
            //Nieuwe memory stream aanmaken die wordt gebruikt door de formatter
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            using (MemoryStream stream = new MemoryStream())
            {
                //Binary formatter die de data serialized, en dit in de stream zet
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, lengte);

                int i = 0;

                while (i < lengte)
                {
                    //formatter.Serialize(stream, array[i]);
                    i++;
                }

                //Return
                return stream.ToArray();
            }
        }

        private static string Deserialize(byte[] data)
        {
            string buf8, opslag = "";

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

                    buf8 = l1;


                    int i = 0;
                    while (i < l2)
                    {
                        var d7 = formatter.Deserialize(stream);
                        string buf7 = Convert.ToString(d7);
                        opslag = (opslag  + buf7 + "\n");
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
    }
}

