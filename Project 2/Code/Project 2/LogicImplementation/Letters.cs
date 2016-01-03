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
        //Make private Directory
        private Dictionary<int, char> dict = new Dictionary<int, char>();

        //Read CSV-file
        //https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
        public void readCSV(string path)
        {
            var reader = new StreamReader(File.OpenRead(path));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                string[] values2 = line.Split(';');
                if (values.Length > 1)
                {
                    dict.Add(Convert.ToInt32(values[1]), Convert.ToChar(values[0]));
                }
                if (values2.Length > 1)
                {
                    dict.Add(Convert.ToInt32(values2[1]), Convert.ToChar(values2[0]));
                }
            }
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
