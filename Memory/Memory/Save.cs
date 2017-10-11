using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp1
{
    [Serializable]
    public class Save
    {
        public struct GameData
        {
            public string Naam1;
            public int TurnCounter;
            public int Score;

            //de constructor
            public GameData (string speler_1, int turn, int score)
            {
                Naam1 = speler_1;
                TurnCounter = turn;
                Score = score;
            }
        }
        

        

        
        public static string SaveData()
        {
            
            Save save = new Save();
            //invoer van naam + lege turn + lege score
            int icounter = 0, score = 0;
            string speler_1 = "Sam";

            //omzetten naar bytes
            byte[] serialized = Serialize(icounter,score,speler_1);

            WriteToFile(@"C:\Users\svnoo\Documents\GitHub\Project-Memory\Memory\Memory\Savegames\game.sav", serialized);


            //het ophalen van de bytes uit de .sav
            byte[] bytes = ReadFromFile(@"C:\Users\svnoo\Documents\GitHub\Project-Memory\Memory\Memory\Savegames\game.sav");

            //Terugzetten van bytes naar data
            string opslag = Deserialize(bytes);

            //variabelen teruggeven aan button die een label aanpast
            return (opslag);
        }

        private static byte[] Serialize(int data1,int data2, string data3)
        {
            //Nieuwe memory stream aanmaken die wordt gebruikt door de formatter
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            using (MemoryStream stream = new MemoryStream())
            {
                //Binary formatter die de data serialized, en dit in de stream zet
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, data1);
                formatter.Serialize(stream, data2);
                formatter.Serialize(stream, data3);

                //Return
                return stream.ToArray();
            }
        }

        private static string Deserialize(byte[] data)
        {
            //Nieuwe memory stream aanmaken die wordt gebruikt door de formatter
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            //De data uit de .sav wordt in de stream gezet
            using (MemoryStream stream = new MemoryStream(data))
            {
                //Binary formatter die de data deserialized, en dit in de stream zet
                BinaryFormatter formatter = new BinaryFormatter();

                //Return de game data.
                var d1 = formatter.Deserialize(stream);
                var d2 = formatter.Deserialize(stream);
                var d3 = formatter.Deserialize(stream);
                string buf1,buf2,buf3,opslag;
                buf1 = Convert.ToString(d1);
                buf2 = Convert.ToString(d2);
                buf3 = Convert.ToString(d3);
                opslag = (buf1 + "\n" + buf2 + "\n" + buf3);
                return opslag;
            }
        }

        private static void WriteToFile(string file, byte[] data)
        {
            //Try catch block om eventuele errors op te vangen.
            try
            {
                //Write van bytes naar opgegeven path
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
                //Read van bytes vanuit opgegeven path
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