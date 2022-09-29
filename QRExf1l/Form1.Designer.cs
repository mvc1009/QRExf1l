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
            this.picQR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textQR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQR
            // 
            this.buttonQR.Location = new System.Drawing.Point(383, 418);
            this.buttonQR.Name = "buttonQR";
            this.buttonQR.Size = new System.Drawing.Size(75, 23);
            this.buttonQR.TabIndex = 0;
            this.buttonQR.Text = "Convert";
            this.buttonQR.UseVisualStyleBackColor = true;
            this.buttonQR.Click += new System.EventHandler(this.buttonQR_Click);
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(31, 77);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(427, 332);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQR.TabIndex = 1;
            this.picQR.TabStop = false;
            this.picQR.Click += new System.EventHandler(this.picQR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "QRExf1l";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textQR
            // 
            this.textQR.Location = new System.Drawing.Point(120, 420);
            this.textQR.Name = "textQR";
            this.textQR.Size = new System.Drawing.Size(257, 20);
            this.textQR.TabIndex = 3;
            this.textQR.TextChanged += new System.EventHandler(this.textQR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 32);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "by mvc1009";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(31, 418);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(83, 23);
            this.btnFile.TabIndex = 6;
            this.btnFile.Text = "Open File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.buttonQR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQR;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnFile;
    }
}

