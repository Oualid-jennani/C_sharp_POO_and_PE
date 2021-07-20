using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_N_3_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedIndex.ToString();
            textBox3.Text = listBox1.SelectedItem.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(AJ.Text);
            textBox1.Text = listBox1.Items.Count.ToString();
            AJ.Clear();
            AJ.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Index = int.Parse(SL.Text);
            if (Index > -1 && Index < listBox1.Items.Count)
            {
                listBox1.SetSelected(Index, true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            SL.Clear();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AJ.Focus();
        }

        private void AJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
