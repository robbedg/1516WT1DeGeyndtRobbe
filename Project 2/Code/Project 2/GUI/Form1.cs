using LogicImplementation;
using LogicInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        //Initialize Frequenties
        IFrequencies frequencies = null;
        //Initialize Letters
        ILetters letters = null;
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonOpenfile_Click(object sender, EventArgs e)
        {
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.openfiledialog(v=vs.110).aspx
            OpenFileDialog WAVwindow = new OpenFileDialog();

            WAVwindow.Filter = "WAVE Files (*.wav, *.wave, *.WAV, *.WAVE)|*.wav;*.wave;*.WAV;*.WAVE|All Files (*.*)|*.*";
            WAVwindow.FilterIndex = 1;
            WAVwindow.RestoreDirectory = true;

            if (WAVwindow.ShowDialog() == DialogResult.OK)
            {
                string path = WAVwindow.FileName;
                textBoxWAVpath.Text = path;
                //Update text
                labelStatus.Text = "Reading WAVE...";
                this.Refresh();

                //Try reading WAVE
                try
                {
                    frequencies = new Frequencies();
                    frequencies.readWAV(path);
                    labelStatus.Text = "OK";
                    if (letters != null)
                    {
                        buttonCalc.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    labelStatus.Text = "Could not read WAVE.";
                    buttonCalc.Enabled = false;
                }
            }
        }

        private void numericSeconds_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog CSVwindows = new OpenFileDialog();

            CSVwindows.Filter = "CSV Files (*.csv, *.CSV)|*.csv;*.CSV|All Files (*.*)|*.*";
            CSVwindows.FilterIndex = 1;
            CSVwindows.RestoreDirectory = true;

            if (CSVwindows.ShowDialog() == DialogResult.OK)
            {
                string path = CSVwindows.FileName;
                textBoxPath.Text = path;
                //Update Text
                labelStatus.Text = "Reading CSV...";
                this.Refresh();
                try
                {
                    letters = new Letters();
                    letters.readCSV(path);
                    labelStatus.Text = "OK";
                    if (frequencies != null)
                    {
                        buttonCalc.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    labelStatus.Text = "Could not read CSV.";
                    letters = null;
                    buttonCalc.Enabled = false;
                }
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Processing...";
            this.Refresh();
            try
            {
                //Do calculations
                int[] frequencyArray = frequencies.getFrequencies(numericSeconds.Value);
                richTextBoxOutput.Text = letters.getLetters(frequencyArray);
                labelStatus.Text = "OK";
            }
            catch (Exception)
            {
                labelStatus.Text = "Could not calculate result.";
                frequencies = null;
                buttonCalc.Enabled = false;
            }

        }
    }
}
 