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
    public partial class EditeazaNotaForm : Form
    {
        private Nota nota;
        private string connectionString = "Data Source = parfumerie.db";

        public EditeazaNotaForm(Nota nota)
        {
            InitializeComponent();
            this.nota = nota;
            PopulateInputFields();
        }

        private void PopulateInputFields()
        {
            tbID.Text = nota.Id.ToString();
            tbDenumire.Text = nota.Denumire;
            tbPretPerMl.Text = nota.PretPerMl.ToString();
        }

        private void btnActualizeazaNota_Click(object sender, EventArgs e)
        {
            if(InputIsValid())
            {
                UpdateNota(nota);
                UpdateNotaInDB(nota);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool InputIsValid()
        {
            return ValidatorNota.ValidateInput(errorProvider1, false, new List<Nota>(), tbID, tbDenumire, tbPretPerMl);
        }

        private void UpdateNota(Nota nota)
        {
            nota.Id = int.Parse(tbID.Text);
            nota.Denumire = tbDenumire.Text;
            nota.PretPerMl = float.Parse(tbPretPerMl.Text);
        }

        private void UpdateNotaInDB(Nota nota)
        {
            string query = "UPDATE Note SET Denumire=@denumire, Pret=@pret WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@denumire", nota.Denumire);
                    command.Parameters.AddWithValue("@pret", nota.PretPerMl);
                    command.Parameters.AddWithValue("@id", nota.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}