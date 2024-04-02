using Microsoft.Data.Sqlite;
using Parfumerie_WindowsFormsApp.Validatori_input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfumerie_WindowsFormsApp
{
    public partial class EditeazaClientForm : Form
    {
        private Client client;
        private string connectionString = "Data Source = parfumerie.db";
        public EditeazaClientForm(Client client)
        {
            InitializeComponent();
            this.client = client;
            PopulateInputFields();
        }

        private void PopulateInputFields()
        {
            tbID.Text = client.Id.ToString();
            tbNume.Text = client.Nume;
            tbPrenume.Text = client.Prenume;
            tbTelefon.Text = client.Telefon;
            tbEmail.Text = client.Email;
        }

        private void btnActualizeazaClient_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
            {
                UpdateClient(client);
                UpdateClientInDB(client);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public bool InputIsValid()
        {
            return ValidatorClient.ValidateInput(tbID, tbNume, tbPrenume, tbTelefon, tbEmail, errorProvider1, true, new List<Client>());
        }

        private void UpdateClient(Client client)
        {
            client.Id = int.Parse(tbID.Text);
            client.Nume = tbNume.Text;
            client.Prenume = tbPrenume.Text;
            client.Telefon = tbTelefon.Text;
            client.Email = tbEmail.Text;
        }

        private void UpdateClientInDB(Client client)
        {
            string query = "UPDATE Clienti SET Nume=@nume, Prenume=@prenume, Telefon=@telefon, Email=@email  WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", client.Id);
                    command.Parameters.AddWithValue("@nume", client.Nume);
                    command.Parameters.AddWithValue("@prenume", client.Prenume);
                    command.Parameters.AddWithValue("@telefon", client.Telefon);
                    command.Parameters.AddWithValue("@email", client.Email);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}