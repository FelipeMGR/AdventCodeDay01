using AdventCodeDay01;
using System;

namespace AdventoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter cv = new Converter();
            string path = "C:\\Users\\felip\\OneDrive\\Documents\\advent01.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string[] content = sr.ReadToEnd().Split('\n', ' ');
                List<int> converted = cv.convertToInt(content);
                List<int> distance = cv.calculoDistancia(converted);

                int distanceSum = cv.distanceSum(distance);
                Console.WriteLine($"The total distance is: {distanceSum}");
            }
        }
    }
}
