using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı_App
{
    public partial class Form1 : Form
    {
        #region Parameters

        int s1, s2, s3, s4;

        int t1, t2, t3, t4;

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += r.Next(5, 15);
            pictureBox2.Left += r.Next(5, 15);
            pictureBox3.Left += r.Next(5, 15);
            pictureBox4.Left += r.Next(5, 15);

            if (t1+ pictureBox1.Left>=finish)
            {
                timer1.Stop();
                MessageBox.Show("1 Numaralı Albaturay Yarışı Kazandı");
            }

            else if (t2 + pictureBox2.Left >= finish)
            {
                timer1.Stop();
                MessageBox.Show("2 Numaralı Huysuz Yarışı Kazandı");
            }

            else if (t3 + pictureBox3.Left >= finish)
            {
                timer1.Stop();
                MessageBox.Show("3 Numaralı Nazlı Yarışı Kazandı");
            }

            else if (t4 + pictureBox4.Left >= finish)
            {
                timer1.Stop();
                MessageBox.Show("4 Numaralı Kaan Yarışı Kazandı");
            }
        }

        int finish;

        #endregion

        #region Definitions

        Random r = new Random();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s1 = pictureBox1.Left;
            s2 = pictureBox2.Left;
            s3 = pictureBox3.Left;
            s4 = pictureBox4.Left;

            t1 = pictureBox1.Width;
            t2 = pictureBox2.Width;
            t3 = pictureBox3.Width;
            t4 = pictureBox4.Width;

            finish = panel6.Left;
        }
    }
}
