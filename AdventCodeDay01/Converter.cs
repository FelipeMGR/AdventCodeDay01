using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventCodeDay01
{
    internal class Converter
    {
        public List<int> convertToInt(string[] array)
        {

            List<int> convertedArray = new List<int>();
            string pattern = @"\d+";

            foreach (string line in array)
            {
                MatchCollection matches = Regex.Matches(line, pattern);
                foreach (Match match in matches)
                {
                    if (int.TryParse(match.Value, out int number))
                    {
                        convertedArray.Add(number);
                    }

                    else
                    {
                        Console.WriteLine("Conversão não realizada");
                    }
                }
            }
            return convertedArray;
        }

        public List<int> calculoDistancia(List<int> list)
        {
            List<int> calculatedValue = new List<int>();

            for (int i = 0; i < list.Count - 1;i++)
            {
                int distance;
                int value1 = list[i];
                int value2 = list[i + 1];
                if (value1 > value2)
                {
                    distance = value1 - value2;
                    calculatedValue.Add(distance);
                }
                else
                {
                    distance = value2 - value1;
                }
            }
            return calculatedValue;
        }

        public int distanceSum(List<int> list)
        {
            int sum = 0;
            foreach(int value in list)
            {
                sum += value;
            }

            return sum;
        }

    }
}
