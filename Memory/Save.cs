using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Save
{
    public class Program
    {
        // Struct
        [Serializable]
        public struct GameData
        {
            public string Naam1;
            public int TurnCounter;
            public int Score;

            //De constructor.
            public GameData(string speler_1, int turn, int score)
            {
                naam1 = speler_1;
                TurnCounter = turn;
                Score = score;
                
            }
        }

        static void Main(string[] args)
        {
            //invoer van naam + lege turn + lege score
            Console.WriteLine("Vul hier je naam in");
            string name = Console.ReadLine();
            int icounter = 0, score = 0;
            GameData gameData = new GameData(Name, icounter, score);

            //omzetten naar bytes
            byte[] serialized = Serialize(gameData);

            WriteToFile(@"C:\Users\svnoo\Documents\GitHub\Project-Memory\Memory\Memory\Savegames", serialized);


            //het ophalen van de bytes uit de .sav
            byte[] bytes = ReadFromFile(@"C:\Users\svnoo\Documents\GitHub\Project-Memory\Memory\Memory\Savegames");

            //Terugzetten van bytes naar data
            GameData deserialized = Deserialize(bytes);

            //Writen van de variabelen
            Console.WriteLine(deserialized.Naam1);
            Console.WriteLine(deserialized.TurnCounter);
            Console.WriteLine(deserialized.Score);

            Console.ReadLine();
        }

        private static byte[] Serialize(GameData data)
        {
            //Maak een nieuwe memory stream aan, die wordt gebruikt door de binary formatter.
            //De 'using' zorgt er voor dat de memory stream altijd correct wordt afgesloten.
            using (MemoryStream stream = new MemoryStream())
            {
                //We maken een binary formatter aan en zeggen dat hij de data moet serializen (output wordt in de memory stream gezet).
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, data);

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