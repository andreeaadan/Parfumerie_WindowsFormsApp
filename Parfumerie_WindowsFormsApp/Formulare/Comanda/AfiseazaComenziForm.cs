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
    public partial class AfiseazaComenziForm : Form
    {
        private List<Comanda> comenzi;
        private string connectionString = "Data Source = parfumerie.db";

        Dictionary<Categorie, string> categorieDisplayStrings = new Dictionary<Categorie, string>
        {
            { Categorie.ApaDeToaleta, "Apa de toaleta" },
            { Categorie.ApaDeParfum, "Apa de parfum" },
            { Categorie.ApaDeColonie, "Apa de colonie" }
        };

        public AfiseazaComenziForm(List<Comanda> comenzi)
        {
            InitializeComponent();
            this.comenzi = comenzi;
            DisplayComenzi();
        }

        private void DisplayComenzi()
        {
            comenzi.Sort();
            lvComenzi.Items.Clear();
            foreach (Comanda comanda in comenzi)
            {
                ListViewItem lvItem = new ListViewItem(comanda.Id.ToString());
                lvItem.SubItems.Add(comanda.Data.ToString("dd.MMMM.yyyy"));
                lvItem.SubItems.Add(comanda.Client.ToString());

                string categorieString = categorieDisplayStrings[comanda.Categorie];
                lvItem.SubItems.Add(categorieString);

                lvItem.SubItems.Add(comanda.Nota.ToString());
                lvItem.SubItems.Add(comanda.CantitateInMl.ToString());
                lvItem.SubItems.Add(comanda.Pret.ToString());
                lvItem.SubItems.Add(comanda.Accente.ToString());

                lvItem.Tag = comanda;
                lvComenzi.Items.Add(lvItem);
            }

        }

        private void DeleteComandaFromDB(Comanda comanda)
        {
            string query = "DELETE FROM Comenzi WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", comanda.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (lvComenzi.SelectedItems.Count == 1)
            {
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = lvComenzi.SelectedItems[0];
            Comanda comanda = (Comanda)lvItem.Tag;

            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti comanda?", "Stergere comanda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteComandaFromDB(comanda);
                comenzi.Remove(comanda);
                DisplayComenzi();
            }
        }
    }
}