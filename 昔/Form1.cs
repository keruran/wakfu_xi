using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 昔
{
    public partial class Form1 : Form
    {
        int num = 0;
        int add = 6;
        int dex = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num=num-add;
            if (num < 1)
            {
                num = num + 24;
            }
            ChangeImg(num);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            num = num + add;
            if (num > 24)
            {
                num = num - 24;
            }
            ChangeImg(num);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            num = num - 1;
            if (num < 1)
            {
                num = num + 24;
            }
            ChangeImg(num);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = num + 1;
            if (num > 24)
            {
                num = num - 24;
            }
            ChangeImg(num);
        }
        public void ChangeImg(int num)
        {
            num = num + dex;
            if (num > 24)
            {
                num = num - 24;
            }
            switch (num)
            {
                case 1:
                    pictureBox1.Image = 昔.Properties.Resources._01;
                    break;
                case 2:
                    pictureBox1.Image = 昔.Properties.Resources._02;
                    break;
                case 3:
                    pictureBox1.Image = 昔.Properties.Resources._03;
                    break;
                case 4:
                    pictureBox1.Image = 昔.Properties.Resources._04;
                    break;
                case 5:
                    pictureBox1.Image = 昔.Properties.Resources._05;
                    break;
                case 6:
                    pictureBox1.Image = 昔.Properties.Resources._06;
                    break;
                case 7:
                    pictureBox1.Image = 昔.Properties.Resources._07;
                    break;
                case 8:
                    pictureBox1.Image = 昔.Properties.Resources._08;
                    break;
                case 9:
                    pictureBox1.Image = 昔.Properties.Resources._09;
                    break;
                case 10:
                    pictureBox1.Image = 昔.Properties.Resources._10;
                    break;
                case 11:
                    pictureBox1.Image = 昔.Properties.Resources._11;
                    break;
                case 12:
                    pictureBox1.Image = 昔.Properties.Resources._12;
                    break;
                case 13:
                    pictureBox1.Image = 昔.Properties.Resources._13;
                    break;
                case 14:
                    pictureBox1.Image = 昔.Properties.Resources._14;
                    break;
                case 15:
                    pictureBox1.Image = 昔.Properties.Resources._15;
                    break;
                case 16:
                    pictureBox1.Image = 昔.Properties.Resources._16;
                    break;
                case 17:
                    pictureBox1.Image = 昔.Properties.Resources._17;
                    break;
                case 18:
                    pictureBox1.Image = 昔.Properties.Resources._18;
                    break;
                case 19:
                    pictureBox1.Image = 昔.Properties.Resources._19;
                    break;
                case 20:
                    pictureBox1.Image = 昔.Properties.Resources._20;
                    break;
                case 21:
                    pictureBox1.Image = 昔.Properties.Resources._21;
                    break;
                case 22:
                    pictureBox1.Image = 昔.Properties.Resources._22;
                    break;
                case 23:
                    pictureBox1.Image = 昔.Properties.Resources._23;
                    break;
                case 24:
                    pictureBox1.Image = 昔.Properties.Resources._24;
                    break;



            }


        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            add = 6;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            add = 5; 
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            add = 4;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            add = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            add = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            add = 1;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            dex= 1;
            ChangeImg(num);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            dex= 2;
            ChangeImg(num);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            dex= 3;
            ChangeImg(num);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            dex= 4;
            ChangeImg(num);
        }


        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dex= 5;
            ChangeImg(num);
        }


        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            dex= 6;
            ChangeImg(num);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作：烤肉肉\r\n图片：吃猫的鱼");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就这么20个按钮，使劲戳就行了。\r\nPageUp和PageDown是快捷键。");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeImg(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = 0;
            ChangeImg(num);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.PageUp)
            {
                button1.PerformClick();
                e.Handled = true;
            }
            if (e.KeyValue == (char)Keys.PageDown)
            {
                button2.PerformClick();
                e.Handled = true;
            }
        }






            

    }
}
