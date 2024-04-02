using Microsoft.Data.Sqlite;
using Parfumerie_WindowsFormsApp.Validatori_input;
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
    public partial class AdaugaNotaForm : Form
    {
        private List<Nota> note;
        private string connectionString = "Data Source = parfumerie.db";
        public AdaugaNotaForm(List<Nota> note)
        {
            InitializeComponent();
            this.note = note;
        }

        private void btnAdaugaNota_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
            {
                Nota nota = CreateNotaFromInput();
                AddNotaToDB(nota);
                note.Add(nota);
                ClearInputFields();
            }
        }

        private bool InputIsValid()
        {
            return ValidatorNota.ValidateInput(errorProvider1, true, note, tbID, tbDenumire, tbPretPerMl);
        }

        private Nota CreateNotaFromInput()
        {
            Nota nota = new Nota
            {
                Id = int.Parse(tbID.Text),
                Denumire = tbDenumire.Text.Trim(),
                PretPerMl = float.Parse(tbPretPerMl.Text)
            };

            return nota;
        }

        private void AddNotaToDB(Nota nota)
        {
            string query = "INSERT INTO Note(Id, Denumire, Pret) VALUES(@id, @denumire, @pret)";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", nota.Id);
                    command.Parameters.AddWithValue("@denumire", nota.Denumire);
                    command.Parameters.AddWithValue("@pret", nota.PretPerMl);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void ClearInputFields()
        {
            tbID.Clear();
            tbDenumire.Clear();
            tbPretPerMl.Clear();
        }

        private void btnAfiseazaNote_Click(object sender, EventArgs e)
        {
            AfiseazaNoteForm afiseazaNoteForm = new AfiseazaNoteForm(note);
            afiseazaNoteForm.ShowDialog();
        }
    }
}