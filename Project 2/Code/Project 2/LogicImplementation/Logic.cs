using DataImplementation;
using DataInterfaces;
using FourierLib;
using LogicInterfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicImplementation
{
    public class Logic : ILogic
    {
        IReadWAV readwav = new ReadWAV();

        //Array with samples/letters
        public float[][] array { get; set; }

        //Fourier on arrays
        public void doFourier(int samplelength, string path)
        {
            float[] wav = readwav.getWav(path);
            int samplesize = samplelength * 44100;

            //amount of letters in a the wav
            int amount = (wav.Count() / samplesize);
 

            array = new float[amount][];

            //Split array in individual letters.
            for (int i = 0; i < amount; i++)
            {
                array[i] = (getSubarray(wav, (i * samplesize), (i * samplesize) + samplesize));
            }

            //Do fourrier transformation.
            for (int i = 0; i < amount; i++)
            {
                Fourier.RFFT(array[i], FourierDirection.Forward);
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
