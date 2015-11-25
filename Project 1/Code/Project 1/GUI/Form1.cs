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
    public partial class Form1 : Form
    {
        IWriteWAVE ww = new WriteWAVE();
        public char[] text;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            text = TextBox.Text.ToLower().ToCharArray();
            ww.readCSV();
            ww.textArray = text;
            ww.toWAVE();

            SoundPlayer sound = new SoundPlayer("test.wav");
            sound.Play();
        }
    }
}
