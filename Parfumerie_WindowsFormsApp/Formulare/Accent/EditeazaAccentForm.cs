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
    public partial class EditeazaAccentForm : Form
    {
        private Accent accent;
        private readonly string connectionString = "Data Source = parfumerie.db";

        public EditeazaAccentForm(Accent accent)
        {
            InitializeComponent();
            this.accent = accent;
            PopulateInputFields();
        }

        private void PopulateInputFields()
        {
            tbID.Text = accent.Id.ToString();
            tbDenumire.Text = accent.Denumire;
            tbPretPerMl.Text = accent.PretPerMl.ToString();
        }

        private void btnActualizeazaAccent_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
            {
                UpdateAccent(accent);
                UpdateAccentInDB(accent);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool InputIsValid()
        {
            return ValidatorAccent.ValidateInput(errorProvider1, false, new List<Accent>(), tbID, tbDenumire, tbPretPerMl);
        }

        private void UpdateAccent(Accent accent)
        {
            accent.Id = int.Parse(tbID.Text);
            accent.Denumire = tbDenumire.Text;
            accent.PretPerMl = float.Parse(tbPretPerMl.Text);
        }

        private void UpdateAccentInDB(Accent accent)
        {
            string query = "UPDATE Accente SET Denumire=@denumire, Pret=@pret WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@denumire", accent.Denumire);
                    command.Parameters.AddWithValue("@pret", accent.PretPerMl);
                    command.Parameters.AddWithValue("@id", accent.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
