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

        //Return Array with frequenties
        public int[] getFrequencies(decimal samplelength, string path)
        {
            float[] wav = readwav.getWav(path);
            int samplesize = (int)(samplelength * 44100);

            //amount of letters in a the wav
            int amount = (int)(wav.Count() / samplesize);
 

            float[][] array = new float[amount][];

            //Split array in individual letters.
            for (int i = 0; i < amount; i++)
            {
                array[i] = (getSubarray(wav, (i * samplesize), (i * samplesize) + samplesize));
            }

            //Float cutting to a power of 2;
            float[][] newarray = new float[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                double j = 1;
                double lengthnew = lengthnew = 2;
                for (int z = 0; z < array[i].Length; z++)
                {
                    j++;
                    if (Math.Pow(2, j) < array[i].Length)
                    {
                        lengthnew = Math.Pow(2, j);
                    }
                    
                }
                newarray[i] = new float[(int)lengthnew];
                for (int k = 0; k < newarray[i].Length; k++)
                {
                    newarray[i][k] = array[i][k];
                }
            }

            //Do fourrier transformation.
            for (int i = 0; i < amount; i++)
            {
                Fourier.RFFT(newarray[i], FourierDirection.Forward);
            }

            //berekenen van vermogen
            double[][] powerarray = new double[newarray.Length][];

            for (int i = 0; i < newarray.Length; i++)
            {
                double[] temparray = new double[newarray[i].Length / 2];
                int k = 0;
                for (int j = 0; j < newarray[i].Length; j = j + 2)
                {
                    temparray[k] = Math.Sqrt(Math.Pow(newarray[i][j], 2.0) + Math.Pow(newarray[i][j + 1], 2.0));
                    k++;
                }
                powerarray[i] = temparray;
            }

            //Get index of maximum
            int[] maxindex = new int[powerarray.Length];
            for (int i = 0; i < powerarray.Length; i++)
            {
                int indexmax = 0;
                double valmax = 0;
                for (int j = 0; j < powerarray[i].Length; j++)
                {
                    if (powerarray[i][j] > valmax)
                    {
                        indexmax = j;
                        valmax = powerarray[i][j];
                    }
                }
                maxindex[i] = indexmax;
            }

            //Get frequencies
            int[] frequencies = new int[maxindex.Length];
            for (int i = 0; i < frequencies.Length; i++)
            {
                frequencies[i] = (maxindex[i] * 44100) / newarray[i].Length;
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
