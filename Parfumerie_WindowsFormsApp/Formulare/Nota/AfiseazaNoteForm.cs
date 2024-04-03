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
    public partial class AfiseazaNoteForm : Form
    {
        private List<Nota> note;
        private readonly string connectionString = "Data Source = parfumerie.db";

        public AfiseazaNoteForm(List<Nota> note)
        {
            InitializeComponent();
            this.note = note;
            DisplayNote();
        }

        private void DisplayNote()
        {
            note.Sort();
            lvNote.Items.Clear();
            foreach (Nota nota in note)
            {
                ListViewItem lvItem = new ListViewItem(nota.Id.ToString());
                lvItem.SubItems.Add(nota.Denumire);
                lvItem.SubItems.Add(nota.PretPerMl.ToString());

                lvItem.Tag = nota;
                lvNote.Items.Add(lvItem);
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = lvNote.SelectedItems[0];
            Nota nota = (Nota)lvItem.Tag;

            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti nota?", "Stergere nota",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteNotaFromDB(nota);
                note.Remove(nota);
                DisplayNote();
            }
        }

        private void DeleteNotaFromDB(Nota nota)
        {
            string query = "DELETE FROM Note WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", nota.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (lvNote.SelectedItems.Count == 1)
            {
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void lvNote_DoubleClick(object sender, EventArgs e)
        {
            if (lvNote.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvNote.SelectedItems[0];
                Nota nota = (Nota)selectedItem.Tag;

                EditeazaNotaForm editeazaNotaForm = new EditeazaNotaForm(nota);
                if (editeazaNotaForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayNote();
                }
            }
        }

        private void AfiseazaNoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdaugaNotaForm adaugaNotaForm = Application.OpenForms.OfType<AdaugaNotaForm>().FirstOrDefault();
            if (adaugaNotaForm != null)
            {
                adaugaNotaForm.TopMost = true;
                adaugaNotaForm.Show();
            }
        }
    }
}