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
            string output = "";
            Save save = new Save();
            //invoer van naam + lege turn + lege score
            int icounter = 0, score = 0;
            string speler_1 = "Sam";

            //omzetten naar bytes
            byte[] serialized = Serialize(icounter,score,speler_1);

            WriteToFile(@"C:\Users\svnoo\Documents\GitHub\Project-Memory\Memory\Memory\Savegames", serialized);


            //het ophalen van de bytes uit de .sav
            byte[] bytes = ReadFromFile(@"C:\Users\svnoo\Documents\GitHub\Project-Memory\Memory\Memory\Savegames");

            //Terugzetten van bytes naar data
            GameData deserialized = Deserialize(bytes);

            //Writen van de variabelen
            output = deserialized.Naam1 + "/n" + deserialized.TurnCounter + "/n" + deserialized.Score;
            return (output);
        }

        private static byte[] Serialize(int data1,int data2, string data3)
        {
            //Maak een nieuwe memory stream aan, die wordt gebruikt door de binary formatter.
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            using (MemoryStream stream = new MemoryStream())
            {
                //We maken een binary formatter aan en zeggen dat hij de data moet serializen (output wordt in de memory stream gezet).
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, data1);
                formatter.Serialize(stream, data2);
                formatter.Serialize(stream, data3);

                //Return
                return stream.ToArray();
            }
        }

        private static GameData Deserialize(byte[] data)
        {
            //Maak een nieuwe memory stream aan, die wordt gebruikt door de binary formatter.
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            //We zetten het data wat we van de uit het bestand hebben gelezen in de memory stream.
            using (MemoryStream stream = new MemoryStream(data))
            {
                //We maken een binary formatter aan en zeggen dat hij de data moet serializen (output wordt in de memory stream gezet).
                BinaryFormatter formatter = new BinaryFormatter();

                //Return de game data.
                return (GameData)formatter.Deserialize(stream);
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