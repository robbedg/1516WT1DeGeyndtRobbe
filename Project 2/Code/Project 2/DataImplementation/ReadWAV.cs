using DataInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImplementation
{
    public class ReadWAV : IReadWAV
    {
        //https://stackoverflow.com/questions/8754111/how-to-read-the-data-in-a-wav-file-to-an-array
        private float bytesToFloat(byte firstByte, byte secondByte)
        {
            //Put 2 bytes together.
            short full = (short)(firstByte | ((int)secondByte) << 8);
            //Return value as float.
            return (float)(Convert.ToDouble(full));
        }

        public float[] getWav(string path)
        {
            //Read file
            byte[] wav = File.ReadAllBytes(path);

            //Get past all the header-chunks
            int pos = 44;

            //length of datachunk (16 bit => 2 bytes)
            int length = (wav.Length - pos) / 2;

            //make Array with de correct length
            float[] sound = new float[length];

            //Put data in float-array
            int i = 0;
            while (pos < wav.Length)
            {
                sound[i] = bytesToFloat(wav[pos], wav[pos + 1]);
                pos += 2;
                i++;
            }

            //return values
            return sound;
        }
    }
}