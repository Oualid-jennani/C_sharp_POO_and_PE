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
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace S7_TP_1
{
    public partial class Form1 : Form
    {
        // Création d'une liste pour stocker les clients
        List<Client> listeClients;

        public Form1()
        {
            InitializeComponent();
            this.listeClients = new List<Client>();
        }

        private void formLoad(object sender, EventArgs e)
        {
            // L'ajout des colonnes
            dataGridView.Columns.Add("lastName", "Nom");
            dataGridView.Columns.Add("firstName", "Prénom");
            dataGridView.Columns.Add("dateNaiss", "Date de naissance");
            dataGridView.Columns.Add("adresse", "Adresse");
            dataGridView.Columns.Add("email", "Email");
            dataGridView.Columns.Add("phone", "Téléphone");
        }

        private void addBtnEvent(object sender, EventArgs e)
        {
            Regex lastNameReg = new Regex("^[a-zA-Z]+$");

            if (!lastNameReg.IsMatch(lastName.Text))
            {
                MessageBox.Show("Nom invalid !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!lastNameReg.IsMatch(firstName.Text))
            {
                MessageBox.Show("Prénom invalid !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Regex regEmail = new Regex(@"^([a-zA-Z0-9\-_\.])+@([a-zA-Z0-9\-_\.])+\.([a-zA-Z0-9\-_\.])+$");

            if (!regEmail.IsMatch(email.Text))
            {
                MessageBox.Show("Email invalid !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Regex regTel = new Regex(@"^(05|06|07)[0-9]{8}$");

            if (!regTel.IsMatch(phone.Text))
            {
                MessageBox.Show("Téléphone invalid !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client c = new Client() { Nom = lastName.Text, Prenom = firstName.Text, DateNaissance = DateTime.Parse(dateNaiss.Text), Adresse = adresse.Text, Email = email.Text, Telephone = phone.Text };

            dataGridView.Rows.Add(c.Nom, c.Prenom, c.DateNaissance, c.Adresse, c.Email, c.Telephone);

            listeClients.Add(c);
        }

        private void deleteBtnEvent(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous supprimer?", "Demande de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( dr == DialogResult.Yes )
            {
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
            }
        }

        private void importXMLEvent(object sender, EventArgs e)
        {
            try {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Console.WriteLine(ofd.FileName);
                    }
                }
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                using (StreamReader reader = new StreamReader(@"C:\Users\pc\Desktop\clients.xml"))
                {
                    List<Client> listeClients = (List<Client>)serializer.Deserialize(reader);
                    reader.Close();

                    foreach (Client c in listeClients)
                    {
                        dataGridView.Rows.Add(c.Nom, c.Prenom, c.DateNaissance, c.Adresse, c.Email, c.Telephone);
                    }
                }
            } catch(Exception) { }
        }

        private void exportXMLEvent(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            using (StreamWriter writer = new StreamWriter(@"C:\Users\pc\Desktop\clients.xml", false))
            {
                serializer.Serialize(writer, listeClients);
                writer.Close();
            }
        }

        private void importBinaryEvent(object sender, EventArgs e)
        {
            BinaryFormatter formater = new BinaryFormatter();
            FileStream flux = new FileStream(@"C:\Users\pc\Desktop\clients.dat", FileMode.Open, FileAccess.Read);

            List<Client> listeClients = (List<Client>)formater.Deserialize(flux);
            flux.Close();

            foreach (Client c in listeClients)
            {
                dataGridView.Rows.Add(c.Nom, c.Prenom, c.DateNaissance, c.Adresse, c.Email, c.Telephone);
            }
        }

        private void exportBinaryEvent(object sender, EventArgs e)
        {
            BinaryFormatter formater = new BinaryFormatter();
            FileStream flux = new FileStream(@"C:\Users\pc\Desktop\clients.dat", FileMode.Create, FileAccess.Write);
            formater.Serialize(flux, listeClients);
            flux.Flush();
            flux.Close();
        }

        private void exitEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
