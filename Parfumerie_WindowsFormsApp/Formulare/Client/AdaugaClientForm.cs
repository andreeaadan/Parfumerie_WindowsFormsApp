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
    public partial class AdaugaClientForm : Form
    {
        private List<Client> clienti;
        private readonly string connectionString = "Data Source = parfumerie.db";
        public AdaugaClientForm(List<Client> clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
            {
                Client client = CreateClientFromInput();
                AddClientToDB(client);
                clienti.Add(client);
                ClearInputFields();
            }
        }

        private bool InputIsValid()
        {
            return ValidatorClient.ValidateInput(tbID, tbNume, tbPrenume, tbTelefon, tbEmail, errorProvider1, true, clienti);
        }

        private Client CreateClientFromInput()
        {
            Client client = new Client
            {
                Id = int.Parse(tbID.Text),
                Nume = tbNume.Text.Trim(),
                Prenume = tbPrenume.Text.Trim(),
                Telefon = tbTelefon.Text,
                Email = tbEmail.Text
            };

            return client;
        }


        private void AddClientToDB(Client client)
        {
            string query = "INSERT INTO Clienti(Id, Nume, Prenume, Telefon, Email) VALUES(@id, @nume, @prenume, @telefon, @email)";

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

        private void ClearInputFields()
        {
            tbID.Clear();
            tbNume.Clear();
            tbPrenume.Clear();
            tbTelefon.Clear();
            tbEmail.Clear();
        }

        private void btnAfiseazaClienti_Click(object sender, EventArgs e)
        {
            AfiseazaClientiForm afiseazaClientiForm = new AfiseazaClientiForm(clienti);
            Hide();
            afiseazaClientiForm.ShowDialog();
        }
    }
}