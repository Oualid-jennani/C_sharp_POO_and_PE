using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_N__3_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(new string[] { "Janvier", "Fevrier", "Mars", "Avril" });
            comboBox1.Items.AddRange(new string[] { "September", "October", "November", "December" });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (!checkBox1.Checked)
            {
                listBox1.SelectionMode = SelectionMode.One;
                if (listBox1.SelectedIndex > -1)
                    listBox2.Items.Add((listBox1.SelectedItem).ToString());
            }
            else
            {
                listBox1.SelectionMode = SelectionMode.MultiSimple;
                foreach (int i in listBox1.SelectedIndices)
                    listBox2.Items.Add(listBox1.Items[i]);
            }
            foreach (int i in checkedListBox1.CheckedIndices)
                listBox2.Items.Add(checkedListBox1.Items[i]);

            if (comboBox1.SelectedIndex > -1)
                listBox2.Items.Add(comboBox1.Text);

            label3.Text = checkedListBox1.CheckedIndices.Count + " elemet (s) coché(s)";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
