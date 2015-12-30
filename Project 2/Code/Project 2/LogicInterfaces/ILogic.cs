using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface ILogic
    {
        float[][] array { get; set; }
        void doFourier(int samplelength, string path);
    }
}
