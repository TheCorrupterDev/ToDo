using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable CS0665

namespace ToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.Height = 460;

            if (Settings1.Default.Welcome = true)
            {
                panel1.Height = 460;
                //Settings1.Default.Welcome = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCnFNEw5xGw6KRsMe6u2woFw");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Height = 0;
            Settings1.Default.Welcome = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel2.Height = 653;
            panel3.Height = 0;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel3.Height = 653;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Height = 0;
            panel3.Height = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Add(textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkedListBox3.Items.Add(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkedListBox3.Items.Clear();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            panel3.Height = 653;
            panel2.Height = 0;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            panel2.Height = 0;
            panel3.Height = 0;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel1.Height = 481;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DimGray;
            panel5.BackColor = Color.DimGray;
            panel2.BackColor = Color.DarkGray;
            panel3.BackColor = Color.DarkGray;
            BackColor = Color.DarkGray;

            Settings1.Default.darkmode = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            BackColor = Color.LightGray;

            Settings1.Default.darkmode = false;
        }
    }
}
