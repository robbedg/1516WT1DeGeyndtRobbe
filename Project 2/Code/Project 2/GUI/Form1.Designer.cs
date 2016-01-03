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
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenfile
            // 
            this.buttonOpenfile.Enabled = false;
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
            this.label1.Location = new System.Drawing.Point(9, 48);
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
            this.numericSeconds.Location = new System.Drawing.Point(12, 64);
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
            this.buttonCSV.TabIndex = 12;
            this.buttonCSV.Text = "Open CSV-file";
            this.buttonCSV.UseVisualStyleBackColor = true;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Result:";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 103);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(260, 146);
            this.richTextBoxOutput.TabIndex = 14;
            this.richTextBoxOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenfile);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

