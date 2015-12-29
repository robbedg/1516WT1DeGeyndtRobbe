using DataImplementation;
using DataInterfaces;
using FourierLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicImplementation
{
    public class Logic
    {
        IReadWAV readwav = new ReadWAV();
        public void test(int samplelength, string path)
        {
            float[] wav = readwav.getWav(path);
            int samplesize = samplelength * 44100;

            //amount of letters in a the wav
            int amount = (wav.Count() / samplesize);
 

            float[][] stack = new float[amount][];

            //Split array in individual letters.
            for (int i = 0; i < amount; i++)
            {
                stack[i][] = (getSubarray(wav, (i * samplesize), (i * samplesize) + samplesize));
            }

            //Do fourrier transformation.
            for (int i = 0; i < amount; i++)
            {
                Fourier.RFFT(stack[i], FourierDirection.Forward);
            }
            
        }

        private float[] getSubarray(float[] input, int start, int end)
        {
            float[] output = new float[end - start];
            int i = 0;
            for (int j = start; j < end; j++)
            {
                output[i] = input[j];
            }
            return output;
        }
    }
}
