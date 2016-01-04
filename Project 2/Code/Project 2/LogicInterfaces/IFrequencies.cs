using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IFrequencies
    {
        void readWAV(string path);
        int[] getFrequencies(decimal samplelength);
    }
}
