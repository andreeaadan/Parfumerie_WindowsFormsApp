using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfumerie_WindowsFormsApp
{
    public partial class AfiseazaClientiForm : Form
    {
        private List<Client> clienti;
        private readonly string connectionString = "Data Source = parfumerie.db";

        public AfiseazaClientiForm(List<Client> clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
            DisplayClienti();
        }

        private void DisplayClienti()
        {
            clienti.Sort();
            lvClienti.Items.Clear();
            foreach (Client client in clienti)
            {
                ListViewItem lvItem = new ListViewItem(client.Id.ToString());
                lvItem.SubItems.Add(client.Nume);
                lvItem.SubItems.Add(client.Prenume);
                lvItem.SubItems.Add(client.Telefon);
                lvItem.SubItems.Add(client.Email);

                lvItem.Tag = client;
                lvClienti.Items.Add(lvItem);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = lvClienti.SelectedItems[0];
            Client client = (Client)lvItem.Tag;

            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti clientul?", "Stergere client",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteClientFromDB(client);
                clienti.Remove(client);
                DisplayClienti();
            }
        }

        private void DeleteClientFromDB(Client client)
        {
            string query = "DELETE FROM Clienti WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", client.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 1)
            {
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = false;
            }

        }

        private void lvClienti_DoubleClick(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvClienti.SelectedItems[0];
                Client client = (Client)selectedItem.Tag;

                EditeazaClientForm editeazaClientForm = new EditeazaClientForm(client);
                if(editeazaClientForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayClienti();
                }
            }
        }

        private void AfiseazaClientiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdaugaClientForm adaugaClientForm = Application.OpenForms.OfType<AdaugaClientForm>().FirstOrDefault();
            if (adaugaClientForm != null)
            {
                adaugaClientForm.TopMost = true;
                adaugaClientForm.Show();
            }
        }
    }
}