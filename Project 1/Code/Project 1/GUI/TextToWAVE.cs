using DataImplementation;
using DataInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TextToWAVE : Form
    {
        IWriteWAVE ww = new WriteWAVE();

        private SoundPlayer sound = null;
        
        public TextToWAVE()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (ww.readCSV(ww.getPath()))
            {
                ww.textArray = TextBox.Text.ToLower().ToCharArray();
                ww.toWAVE(ww.getPath(), numericSeconds.Value);
                labelOutput.Text = "WAVE is ready to play.";
            }
            else
            {
                labelOutput.Text = @"Something went wrong, please check if file table.csv is" + "\r\n" + @"available in directory \Data.";
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(ww.getPath(), @"output.wav");
            try {
                sound = new SoundPlayer(path);
                sound.Play();
                labelOutput.Text = "OK";
            }
            catch(Exception)
            {
                labelOutput.Text = "No soundfile found.";
                labelOutput.Text = path;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                sound.Stop();
                labelOutput.Text = "OK";
            }
            catch(Exception)
            {
                labelOutput.Text = "Action not possible.";
            }
        }
    }
}
