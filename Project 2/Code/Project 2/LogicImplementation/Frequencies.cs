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
    public class Frequencies : IFrequencies
    {
        //make Readwav
        IReadWAV readwav = new ReadWAV();

        //make private float[]
        private float[] wav { get; set; }

        //get Frequencies
        public void readWAV(string path)
        {
            wav = readwav.getWAV(path);
        }

        //Return Array with frequenties
        public int[] getFrequencies(decimal samplelength)
        {
            //calculate samplesize
            int samplesize = (int)(samplelength * 44100);

            //amount of letters in a the wav
            int amount = (int)(wav.Count() / samplesize);
 
            //Array with samples devided by letter.
            float[][] letterarray = new float[amount][];

            //Split array in individual letters.
            for (int i = 0; i < amount; i++)
            {
                letterarray[i] = (getSubarray(wav, (i * samplesize), (i * samplesize) + samplesize));
            }

            //Float cutting to a power of 2 + get new lengths;
            int[] length = new int[letterarray.Length];
            for (int x = 0; x < letterarray.Length; x++)
            {
                //Get new length
                int i = 1;
                while (true)
                {
                    int newlength = (int)Math.Pow(2, i);
                    if (newlength < letterarray[x].Length)
                    {
                        length[x] = newlength;
                    }
                    else
                    {
                        break;
                    }
                    i++;
                }

                //make array with new length
                float[] temp = new float[length[x]];
                    
                //Copy values
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = letterarray[x][j];
                }
                //Change letterarray
                letterarray[x] = temp;
            }

            //Do fourrier transformation.
            for (int i = 0; i < amount; i++)
            {
                Fourier.RFFT(letterarray[i], FourierDirection.Forward);
            }

            //berekenen van vermogen in letterarray
            for (int i = 0; i < letterarray.Length; i++)
            {
                float[] temparray = new float[letterarray[i].Length / 2];
                int k = 0;
                for (int j = 0; j < letterarray[i].Length; j = j + 2)
                {
                    temparray[k] = (float)Math.Sqrt(Math.Pow(letterarray[i][j], 2.0) + Math.Pow(letterarray[i][j + 1], 2.0));
                    k++;
                }
                //change letterarray
                letterarray[i] = temparray;
            }

            //Get index of maximum
            int[] frequencies = new int[letterarray.Length];
            for (int i = 0; i < letterarray.Length; i++)
            {
                int indexmax = 0;
                double valmax = 0;
                for (int j = 0; j < letterarray[i].Length; j++)
                {
                    if (letterarray[i][j] > valmax)
                    {
                        indexmax = j;
                        valmax = letterarray[i][j];
                    }
                }
                //Set max index in frequencies
                frequencies[i] = indexmax;
            }

            //Get frequencies
            for (int i = 0; i < frequencies.Length; i++)
            {
                frequencies[i] = (frequencies[i] * 44100) / length[i];
            }

            //rerturn array with frequenties
            return frequencies;
        }

        private float[] getSubarray(float[] input, int start, int end)
        {
            float[] output = new float[end - start];
            int i = 0;
            for (int j = start; j < end; j++)
            {
                output[i] = input[j];
                i++;
            }
            return output;
        }
    }
}
