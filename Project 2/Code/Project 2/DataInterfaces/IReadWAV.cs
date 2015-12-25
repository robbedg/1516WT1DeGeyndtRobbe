using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterfaces
{
    public interface IReadWAV
    {
        //Gets floatarray of data from WAV file.
        float[] getWav(string path);
    }
}
