using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_N__01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.ResetText();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false) || numericUpDown1.Text=="" || comboBox1.Text=="")
                MessageBox.Show("Donnez toutes les informations s'il vous plaît");
            else
            {
                ListViewItem ls = new ListViewItem();
                ls.Text = textBox1.Text.ToString();
                textBox1.Clear();
                ls.SubItems.Add(textBox2.Text);
                textBox2.Clear();
                ls.SubItems.Add(dateTimePicker1.Text);
                dateTimePicker1.ResetText();
                if (radioButton1.Checked == true)
                {
                    ls.SubItems.Add(radioButton1.Text);
                    radioButton1.Checked = false;
                }
                if (radioButton2.Checked == true)
                {
                    ls.SubItems.Add(radioButton2.Text);
                    radioButton2.Checked = false;
                }
                ls.SubItems.Add(numericUpDown1.Text);
                numericUpDown1.ResetText();
                ls.SubItems.Add(comboBox1.Text);
                comboBox1.SelectedIndex = -1;

                listView1.Items.Add(ls);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i <= listView1.SelectedIndices.Count - 1; i++)
            {
                textBox1.Text = listView1.SelectedItems[i].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[i].SubItems[1].Text;
                dateTimePicker1.Text = listView1.SelectedItems[i].SubItems[2].Text;

                if (listView1.SelectedItems[i].SubItems[3].Text == "Homme") radioButton1.Checked = true;

                if (listView1.SelectedItems[i].SubItems[3].Text == "Femme") radioButton2.Checked = true;

                numericUpDown1.Text = listView1.SelectedItems[i].SubItems[4].Text;
                comboBox1.Text = listView1.SelectedItems[i].SubItems[5].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           foreach(ListViewItem ls in listView1.SelectedItems)
            {
                    listView1.Items.Remove(ls);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                textBox1.Clear();
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                textBox2.Clear();
                listView1.SelectedItems[0].SubItems[2].Text = dateTimePicker1.Text;
                dateTimePicker1.ResetText();
                if (radioButton1.Checked == true)
                {
                    listView1.SelectedItems[0].SubItems[3].Text = radioButton1.Text;
                    radioButton1.Checked = false;
                }
                if (radioButton2.Checked == true)
                {
                    listView1.SelectedItems[0].SubItems[3].Text = radioButton2.Text;
                    radioButton2.Checked = false;
                }
                listView1.SelectedItems[0].SubItems[4].Text = numericUpDown1.Text;
                numericUpDown1.ResetText();
                listView1.SelectedItems[0].SubItems[5].Text = comboBox1.Text;
                comboBox1.SelectedIndex = -1;
            }

        }
    }
}
