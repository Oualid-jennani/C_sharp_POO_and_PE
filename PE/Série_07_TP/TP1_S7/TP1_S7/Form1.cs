using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TP1_S7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("NomC", "Nom");
            dataGridView1.Columns.Add("PrenomC", "Prénom");
            dataGridView1.Columns.Add("DateC", "Date de naissance");
            dataGridView1.Columns.Add("AdresseC", "Adresse");
            dataGridView1.Columns.Add("EmailC", "Email");
            dataGridView1.Columns.Add("TeleC", "Telephone");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex Name = new Regex("^[a-zA-Z]+$");
            Regex PreName = new Regex("^[a-zA-Z]+$");
            Regex Email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex Tele = new Regex(@"^((05)|(06)|(07))((\d){8})+$");
            if (!Name.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Ce n'est pas un nom !");
            }

            else
            if (!PreName.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Ce n'est pas un Prenom !");
            }

            else
            if (!Email.IsMatch(textBox4.Text))
            {
                MessageBox.Show("Ce n'est pas un Email !");
            }
            else
            if (!Tele.IsMatch(textBox5.Text))
            {
                MessageBox.Show("Ce n'est pas un tele !");
            }
            else
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs !", "Verifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Voulez-vous vriment supprimer ces infos", "Supprimer !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
