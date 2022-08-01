using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookEngine
{
    public class RandomGenerator
    {
        private static Random m_Random = new Random(DateTime.Now.Second);
        public static string GetRandomFromType(string i_Type)
        {
            string answer = null;
            switch (i_Type)
            {
                case "Name":
                    {
                        answer = generateRandomName();
                        break;
                    }
                case "Post":
                    {
                        answer = generateRandomPost();
                        break;
                    }
            }
            return answer;
        }


        private static string generateRandomName()
        {
            List<string> listOfFirstNames = new List<string> { "Sebastian", "Ethan", "Logan", "Owen", "Samuel", "Jacob", "Asher", "Aiden", "John", "Joseph", "Wyatt", "David", "Leo", 
                                                            "Luke", "Julian", "Hudson", "Grayson", "Matthew", "Ezra", "Gabriel", "Carter", "Isaac" };
            List<string> listOfLastNames = new List<string> { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez",
                                                                "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas" };
            // Random rnd = new Random(3);
            return listOfFirstNames[m_Random.Next(0, listOfFirstNames.Count)] + " " + listOfLastNames[m_Random.Next(0,listOfLastNames.Count)];
        }

        public static DateTime GenerateRandomDateTime()
        {
            int randomMonth = m_Random.Next(1, 11);
            int randomDay = m_Random.Next(1, 28);
            int randomYear = m_Random.Next(2000, 2020);
            return new DateTime(randomYear, randomMonth, randomDay);
        }

        private static string generateRandomPost()
        {
            List<string> listOfWords = new List<string>
                                           { "abandon", "ability", "able", "beautiful", "beauty", "because", "become",
                                               "candidate", "cap", "capability", "capable", "capacity", "code", "coffee", "cognitive", "customer", "cut", "cycle", "dad",
                                               "daily", "damage", "dance", "economy", "edge", "edition", "female", "fence", "few", "garage", "garden", "garlic",
                                               "gas", "gate", "gather", "gaze", "gear", "ideal", "identification", "identify", "knock", "know", "knowledge", "lab",
                                               "label", "labor", "laboratory", "lack", "lady", "mayor", "me", "meal", "mean", "meaning", "meanwhile", "measure" };
            string randomPost = "";
            int numberOfWords = m_Random.Next(1, 15);
            for(int i = 0; i < numberOfWords; i++)
            {
                int randomWord = m_Random.Next(0, listOfWords.Count);
                randomPost += listOfWords[randomWord] + " ";
            }

            return randomPost;
        }
    }
}
