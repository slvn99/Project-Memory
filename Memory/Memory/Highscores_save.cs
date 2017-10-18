using System;

using System.IO;

using System.Resources;

using System.Runtime.Serialization.Formatters.Binary;

using Memory.Properties;

using System.Collections.Generic;

using System.Collections;



namespace Memory

{

    [Serializable]

    class Highscores_save

    {

        public static int lengte = 0;



        //-------------------------------------------------------------------------------//

        //Caller write

        public static void SaveData(string naam, int score)

        {

            //hier benoem ik path tot de locatie van de .exe

            var path = AppDomain.CurrentDomain.BaseDirectory;

            //declareren van verschillende variabelen

            string[] savearray = new string[12];

            string[] newsavearray = new string[12];

            int lengte = 0;



            //proberen van laden van savedata if aanwezig, anders doet hij niks

            string save = LoadData();

            if (save == "Er is nog geen\nsave file\naanwezig")

            { }

            else

            {

                savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                lengte = LengteLoad(@"" + path + "lengte.ini");

            }



            //lengte +1 ivm 1 extra entry

            if (lengte < 11)

            {

                lengte = lengte + 1;

            }

            //koppelen van score en naam, score vooraan ivm sorteren

            string koppel = score + " punten gehaald door: " + naam;



            if (savearray[0] == null)

            {

                //lege list op basis van niks

                List<string> scorelist = new List<string>();

                scorelist.Add(koppel);

                scorelist.CopyTo(newsavearray);

            }

            else

            {

                //list aanmaken op basis van savearray

                List<string> scorelist = new List<string>(savearray);

                scorelist.Add(koppel);

                scorelist.CopyTo(newsavearray);

            }







            //reverse comparer initialiseren

            IComparer revComparer = new ReverseComparer();

            //de array omgekeerd sorteren op basis van ASCII oid.

            Array.Sort(newsavearray, revComparer);



            //omzetten naar bytes

            byte[] serialized = Serialize(lengte, newsavearray);



            //deze bytes writen

            WriteToFile(@"" + path + "highscores.sav", serialized);



            //lengte writen

            LengteWrite(@"" + path + "lengte.ini", lengte);

        }



        //Caller read

        public static string LoadData()

        {

            //hier benoem ik path tot de locatie van de .exe

            var path = AppDomain.CurrentDomain.BaseDirectory;



            //het ophalen van de bytes uit de .sav

            byte[] bytes = ReadFromFile(@"" + path + "highscores.sav");







            string opslag = Deserialize(bytes);





            //variabelen teruggeven aan button die een label aanpast

            return (opslag);

        }



        //------------------------------------------------------------------------------//

        //Methods

        public static byte[] Serialize(int lengte, string[] savearray)

        {

            //Nieuwe memory stream aanmaken die wordt gebruikt door de formatter

            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.

            using (MemoryStream stream = new MemoryStream())

            {

                //Binary formatter die de data serialized, en dit in de stream zet

                BinaryFormatter formatter = new BinaryFormatter();



                int i = 0;



                while (i < lengte)

                {

                    formatter.Serialize(stream, savearray[i]);

                    i++;

                }



                //Return

                return stream.ToArray();

            }

        }



        private static string Deserialize(byte[] data)

        {

            string opslag = "";



            //Nieuwe memory stream aanmaken die wordt gebruikt door de formatter

            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.

            //De data uit de .sav wordt in de stream gezet

            try

            {

                using (MemoryStream stream = new MemoryStream(data))

                {

                    var path = AppDomain.CurrentDomain.BaseDirectory;



                    //Binary formatter die de data deserialized, en dit in de stream zet

                    BinaryFormatter formatter = new BinaryFormatter();



                    //load het getal welke aangeeft hoeveel entry's de array had

                    int l2 = LengteLoad(@"" + path + "lengte.ini");



                    //Return de game data.

                    int i = 0;

                    while (i < l2)

                    {

                        var d7 = formatter.Deserialize(stream);

                        string buf7 = Convert.ToString(d7);

                        opslag = (opslag + buf7 + "\n");

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

            catch (Exception)

            {

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

            catch (Exception)

            {

            }



            return null;

        }



        private static void LengteWrite(string file, int data)

        {

            //Try catch block om eventuele errors af te vangen.

            try

            {

                string lengte = Convert.ToString(data);

                //Schrijf all bytes naar het opgegeven path.

                File.WriteAllText(file, lengte);

            }

            catch (Exception)

            {

            }

        }

        private static int LengteLoad(string file)

        {

            //Try catch block om eventuele errors af te vangen.

            try

            {

                //Alle bytes uitlezen uit een bestand en deze returnen.

                string buf = File.ReadAllText(file);

                lengte = int.Parse(buf);

                return lengte;

            }

            catch (Exception)

            {

                return lengte = 0;

            }

        }



        public class ReverseComparer : IComparer

        {

            // Call CaseInsensitiveComparer.Compare with the parameters reversed.

            public int Compare(Object x, Object y)

            {

                return (new CaseInsensitiveComparer()).Compare(y, x);

            }

        }



    }

}