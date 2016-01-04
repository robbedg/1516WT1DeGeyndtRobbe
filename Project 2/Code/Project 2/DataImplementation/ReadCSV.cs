using DataInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImplementation
{
    //Read CSV-file
    //https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
    public class ReadCSV : IReadCSV
    {
        public Dictionary<int, char> getCSV(string path)
        {
            Dictionary<int, char> dict = new Dictionary<int, char>();
            using (StreamReader reader = new StreamReader(File.OpenRead(path)))
            {
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
            //return dictionary
            return dict;
        }
    }
}
