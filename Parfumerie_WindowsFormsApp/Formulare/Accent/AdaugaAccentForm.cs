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
    public partial class AdaugaAccentForm : Form
    {
        private List<Accent> accente;
        private readonly string connectionString = "Data Source = parfumerie.db";

        public AdaugaAccentForm(List<Accent> accente)
        {
            InitializeComponent();
            this.accente = accente;
        }
        private void btnAdaugaAccent_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
            {
                Accent accent = createAccentFromInput();
                AddAccentToDB(accent);
                accente.Add(accent);
                ClearInputFields();
            }
        }

        private bool InputIsValid()
        {
            return ValidatorAccent.ValidateInput(errorProvider1, true, accente, tbID, tbDenumire, tbPretPerMl);
        }

        private Accent createAccentFromInput()
        {
            Accent accent = new Accent
            {
                Id = int.Parse(tbID.Text),
                Denumire = tbDenumire.Text.Trim(),
                PretPerMl = float.Parse(tbPretPerMl.Text)
            };

            return accent;
        }

        private void AddAccentToDB(Accent accent)
        {
            string query = "INSERT INTO Accente(Id, Denumire, Pret) VALUES(@id, @denumire, @pret)";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", accent.Id);
                    command.Parameters.AddWithValue("@denumire", accent.Denumire);
                    command.Parameters.AddWithValue("@pret", accent.PretPerMl);
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

        private void btnAfiseazaAccente_Click(object sender, EventArgs e)
        {
            AfiseazaAccenteForm afiseazaAccenteForm = new AfiseazaAccenteForm(accente);
            afiseazaAccenteForm.ShowDialog();
        }
    }
}