namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWAVpath = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenfile
            // 
            this.buttonOpenfile.Location = new System.Drawing.Point(182, 64);
            this.buttonOpenfile.Name = "buttonOpenfile";
            this.buttonOpenfile.Size = new System.Drawing.Size(90, 23);
            this.buttonOpenfile.TabIndex = 0;
            this.buttonOpenfile.Text = "Open WAV-file";
            this.buttonOpenfile.UseVisualStyleBackColor = true;
            this.buttonOpenfile.Click += new System.EventHandler(this.buttonOpenfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seconds per letter:";
            // 
            // numericSeconds
            // 
            this.numericSeconds.DecimalPlaces = 2;
            this.numericSeconds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericSeconds.Location = new System.Drawing.Point(12, 103);
            this.numericSeconds.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericSeconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(149, 20);
            this.numericSeconds.TabIndex = 9;
            this.numericSeconds.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericSeconds.ValueChanged += new System.EventHandler(this.numericSeconds_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CSV-file path:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 25);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(149, 20);
            this.textBoxPath.TabIndex = 11;
            // 
            // buttonCSV
            // 
            this.buttonCSV.Location = new System.Drawing.Point(182, 25);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(90, 23);
            this.buttonCSV.TabIndex = 0;
            this.buttonCSV.Text = "Open CSV-file";
            this.buttonCSV.UseVisualStyleBackColor = true;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Result:";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 142);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(260, 146);
            this.richTextBoxOutput.TabIndex = 14;
            this.richTextBoxOutput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(9, 304);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(22, 13);
            this.labelStatus.TabIndex = 16;
            this.labelStatus.Text = "OK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "WAV-file path:";
            // 
            // textBoxWAVpath
            // 
            this.textBoxWAVpath.Location = new System.Drawing.Point(12, 64);
            this.textBoxWAVpath.Name = "textBoxWAVpath";
            this.textBoxWAVpath.ReadOnly = true;
            this.textBoxWAVpath.Size = new System.Drawing.Size(149, 20);
            this.textBoxWAVpath.TabIndex = 18;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Enabled = false;
            this.buttonCalc.Location = new System.Drawing.Point(182, 103);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(90, 23);
            this.buttonCalc.TabIndex = 19;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxWAVpath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WAV to text";
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWAVpath;
        private System.Windows.Forms.Button buttonCalc;
    }
}

