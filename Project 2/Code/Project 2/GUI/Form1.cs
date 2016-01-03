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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        //Initialize Frequenties
        IFrequencies frequencies = new Frequencies();
        //Initialize Letters
        ILetters letters = new Letters();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenfile_Click(object sender, EventArgs e)
        {
            //https://msdn.microsoft.com/en-us/library/system.windows.forms.openfiledialog(v=vs.110).aspx
            OpenFileDialog window = new OpenFileDialog();

            window.Filter = "WAVE Files (*.wav, *.wave, *.WAV, *.WAVE)|*.wav;*.wave;*.WAV;*.WAVE|All Files (*.*)|*.*";
            window.FilterIndex = 1;
            window.RestoreDirectory = true;

            if (window.ShowDialog() == DialogResult.OK)
            {
                string path = window.FileName;

                //Get Frequencies
                int[] frequencyArray = frequencies.getFrequencies(numericSeconds.Value, path);

                //Get Text
                string output = letters.getLetters(frequencyArray);
                richTextBoxOutput.Text = output;
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
                letters.readCSV(path);
                buttonOpenfile.Enabled = true;
            }
        }
    }
}
 