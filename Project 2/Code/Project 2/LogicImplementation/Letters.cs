using DataImplementation;
using DataInterfaces;
using LogicInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicImplementation
{
    public class Letters : ILetters
    {
        //Get ReadCSV
        IReadCSV readcsv = new ReadCSV();

        //Make private Directory
        private Dictionary<int, char> dict = new Dictionary<int, char>();

        //Read CSV-file
        public void readCSV(string path)
        {
            dict = readcsv.getCSV(path);
        }

        //Return string with message.
        public string getLetters(int[] frequencies)
        {
            //rounding frequencies
            int[] rounded = new int[frequencies.Length];
            for (int i = 0; i < frequencies.Length; i++)
            {
                rounded[i] = Convert.ToInt32(10 * (Math.Round(Convert.ToDouble(frequencies[i]) / 10)));
            }

            //Get chars from dictionary
            char[] chars = new char[frequencies.Length];
            for (int i = 0; i < rounded.Length; i++)
            {
                char x = ' ';
                dict.TryGetValue(rounded[i], out x);
                //If not found, put space.
                if (x == '\0')
                {
                    x = ' ';
                }
                chars[i] = x;
            }

            //return as string
            string output = new string(chars);
            return output;
        }
    }
}
