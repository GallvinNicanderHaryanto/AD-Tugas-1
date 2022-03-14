using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_Tugas_1
{
    public partial class Form1 : Form
    {
        private object labelOutput;

        public object TxtBoxInput { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, EventArgs e)
        {
            button1.BackColor = Color.BlueViolet;
        }
        private void panel1_MouseMove(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private new void Click(object sender, EventArgs e)
        {
            labelOutput = TxtBoxInput;
        }

        private void RadioButtRed_CheckedChanged(object sender, EventArgs e)
        {
            labelOutput = Color.Red;
        }

        private void RadioButtBlue_CheckedChanged(object sender, EventArgs e)
        {
            labelOutput = Color.Blue;
        }

        private void CBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            labelOutput = new Font(Font, FontStyle.Bold);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
        }
    }
}
