using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;


namespace QRExf1l
{

    public partial class Form1 : Form
    {
        private PictureBox p;
        private List<Image> QRImageList;
        private System.Windows.Forms.Timer timer;
        private int count;

        public Form1()
        {
            InitializeComponent();
            p = new PictureBox
            {
                Name = "QRImageBox",
                Size = new Size(400, 400),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            };
            QRImageList = new List<Image>();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = Convert.ToInt32(numericSleep.Value);
            timer.Tick += new EventHandler(timer_Tick);
            count = 0;
            this.Controls.Add(p);
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textQR_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQR_Click(object sender, EventArgs e)
        {


            string text = System.IO.File.ReadAllText(textQR.Text);
            string vartext = "";


            

            for (int i=0; i < text.Length; i=i+ Convert.ToInt32(numericQRLength.Value)) {
                if( (text.Length - i <= numericQRLength.Value))
                {
                    vartext = text.Substring(i);
                }
                else
                {
                    vartext = text.Substring(i, Convert.ToInt32(numericQRLength.Value));
                }
                Console.WriteLine(vartext);
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(vartext, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                QRImageList.Add(qrCode.GetGraphic(5));
            }
            timer.Start();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textQR.Text = ofd.FileName;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void changeImage(Image pic, EventArgs e)
        {
            p.Image = pic;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            p.Image = QRImageList[count];
            if (count < QRImageList.Count -1)
            {
                count++;
            }
            else
            {
                Console.WriteLine("[!] End");
                timer.Stop();
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
