namespace QRExf1l
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textQR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.Label();
            this.numericSleep = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericQRLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQRLength)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQR
            // 
            this.buttonQR.Location = new System.Drawing.Point(409, 439);
            this.buttonQR.Name = "buttonQR";
            this.buttonQR.Size = new System.Drawing.Size(75, 23);
            this.buttonQR.TabIndex = 0;
            this.buttonQR.Text = "Convert";
            this.buttonQR.UseVisualStyleBackColor = true;
            this.buttonQR.Click += new System.EventHandler(this.buttonQR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "QRExf1l";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textQR
            // 
            this.textQR.Location = new System.Drawing.Point(146, 441);
            this.textQR.Name = "textQR";
            this.textQR.Size = new System.Drawing.Size(257, 20);
            this.textQR.TabIndex = 3;
            this.textQR.TextChanged += new System.EventHandler(this.textQR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 25);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "by @mvc1009";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(57, 439);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(83, 23);
            this.btnFile.TabIndex = 6;
            this.btnFile.Text = "Open File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // textStatus
            // 
            this.textStatus.AutoSize = true;
            this.textStatus.Location = new System.Drawing.Point(410, 475);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(0, 13);
            this.textStatus.TabIndex = 7;
            this.textStatus.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericSleep
            // 
            this.numericSleep.Location = new System.Drawing.Point(418, 409);
            this.numericSleep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericSleep.Name = "numericSleep";
            this.numericSleep.Size = new System.Drawing.Size(66, 20);
            this.numericSleep.TabIndex = 9;
            this.numericSleep.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sleep (ms)";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "QR length(chars)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericQRLength
            // 
            this.numericQRLength.Location = new System.Drawing.Point(146, 409);
            this.numericQRLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericQRLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQRLength.Name = "numericQRLength";
            this.numericQRLength.Size = new System.Drawing.Size(68, 20);
            this.numericQRLength.TabIndex = 12;
            this.numericQRLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericQRLength.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 474);
            this.Controls.Add(this.numericQRLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericSleep);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQR);
            this.Name = "Form1";
            this.Text = "QRExf1l";
            ((System.ComponentModel.ISupportInitialize)(this.numericSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQRLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label textStatus;
        private System.Windows.Forms.NumericUpDown numericSleep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericQRLength;
    }
}

