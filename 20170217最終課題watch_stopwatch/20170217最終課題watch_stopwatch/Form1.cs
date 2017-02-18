using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170217最終課題watch_stopwatch
{
    public partial class Form1 : Form
    {
        DateTime dt;
        private double i = 0.0;
        private bool flg = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 100;
            this.label1.AutoSize = false;
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "0.0秒";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!flg)
            {
                this.timer1.Enabled = true;
                flg = true;
                this.button1.Text = "ストップ";
            }
            else
            {
                this.timer1.Enabled = false;
                flg = false;
                this.button1.Text = "スタート";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 0.1;
            label1.Text = i.ToString("0.0") + "秒";
            /*            if (i < 60)
                        {
                            label1.Text = i.ToString() + "秒";
                        }
                        else
                        {
                            label1.Text = (i / 60).ToString() + "分" + (i % 60).ToString() + "秒";
                        }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            label1.Text = "0秒";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            this.label2.Text = dt.ToLongTimeString();

        }
    }
}
