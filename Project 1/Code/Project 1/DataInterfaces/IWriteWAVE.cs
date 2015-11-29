using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterfaces
{
    public interface IWriteWAVE
    {
        char[] textArray { get; set; }
        string getPath();
        bool readCSV(string path);
        void toWAVE(string path, decimal seconds);
    }
}
