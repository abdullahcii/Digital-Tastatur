using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Tastatur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button11);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button31);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button43);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button42);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button49);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button53);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button45_Click(object sender, EventArgs e)
        {
            bool CapsLock = true;
            if (CapsLock)
            {
                CapsLock = false;
                textBox1.Text = textBox1.Text.ToUpper();

            }
            else
            {
                CapsLock = true;
                textBox1.Text = textBox1.Text.ToUpper();
            }

            foreach (Button item in panel1.Controls)
            {
                if (CapsLock)
                    item.Text = item.Text.ToUpper();
                else
                    item.Text = item.Text.ToLower();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " ";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine;
        }
        private void CALLBUTTON(Button BTN)
        {
            if (button51.FlatStyle == FlatStyle.Flat)
            {
                textBox1.Text = textBox1.Text + BTN.Text;
                button51.PerformClick();
            }
            textBox1.Text = textBox1.Text + BTN.Text;


        }
        private void button33_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button33);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button52);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button55);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button54);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button47);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button48);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button50);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button51);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button32);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button8);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button23);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button22);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button21);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button35);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button19);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button14);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button13);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button12);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button10);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button38);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button37);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button36);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button9);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button30);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button29);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button28);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button27);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button26);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button25);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button24);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button56);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button57);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button41);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button40);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            CALLBUTTON(button39);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
