using DataInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataImplementation
{
    public class WriteWAVE : IWriteWAVE
    {
        private Dictionary<char, int> dict { get; set; }

        public char[] textArray { get; set; }

        public void readCSV()
        {
            dict = File.ReadLines("test.csv").Select(line => line.Split(',')).ToDictionary(line => line[0][0], line => Int32.Parse(line[1]));
        }

        public void toWAVE()
        {

            FileStream stream = new FileStream("test.wav", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);

            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            int samples = 44100 * textArray.Count();
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;

            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);

            double ampl = 10000;

            for (int i = 0; i < textArray.Count(); i++)
            {
                int freq = dict[textArray[i]];
                for (int j = 0; j < samples / textArray.Count(); j++)
                {
                    double t = (double)j / (double)samplesPerSecond;
                    short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                    writer.Write(s);
                }
            }
            writer.Close();
            stream.Close();
        }
    }
}
