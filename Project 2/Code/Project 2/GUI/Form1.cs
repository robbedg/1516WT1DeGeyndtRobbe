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
            }
        }
    }
}
 