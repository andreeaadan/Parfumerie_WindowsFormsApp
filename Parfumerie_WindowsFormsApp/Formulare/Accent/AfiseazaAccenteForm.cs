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
    public partial class AfiseazaAccenteForm : Form
    {
        private List<Accent> accente;
        private string connectionString = "Data Source = parfumerie.db";

        public AfiseazaAccenteForm(List<Accent> accente)
        {
            InitializeComponent();
            this.accente = accente;
            DisplayAccente();
        }


        void DisplayAccente()
        {
            accente.Sort();
            lvAccente.Items.Clear();
            foreach (Accent accent in accente)
            {
                ListViewItem lvItem = new ListViewItem(accent.Id.ToString());
                lvItem.SubItems.Add(accent.Denumire);
                lvItem.SubItems.Add(accent.PretPerMl.ToString());

                lvItem.Tag = accent;
                lvAccente.Items.Add(lvItem);
            }
        }

        private void DeleteAccentFromDB(Accent accent)
        {
            string query = "DELETE FROM Accente WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", accent.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (lvAccente.SelectedItems.Count == 1)
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
            ListViewItem lvItem = lvAccente.SelectedItems[0];
            Accent accent = (Accent)lvItem.Tag;

            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti accentul?", "Stergere accent",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteAccentFromDB(accent);
                accente.Remove(accent);
                DisplayAccente();
            }
        }

        private void lvAccente_DoubleClick(object sender, EventArgs e)
        {
            if (lvAccente.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvAccente.SelectedItems[0];
                Accent accent = (Accent)selectedItem.Tag;

                EditeazaAccentForm editeazaAccentForm = new EditeazaAccentForm(accent);
                if(editeazaAccentForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayAccente();
                }
            }
        }
    }
}