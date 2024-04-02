using Microsoft.Data.Sqlite;
using Parfumerie_WindowsFormsApp.Validatori_input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parfumerie_WindowsFormsApp
{
    public partial class AdaugaComandaForm : Form
    {
        private List<Accent> accente;
        private List<Nota> note;
        private List<Client> clienti;
        private List<Comanda> comenzi;
        private string connectionString = "Data Source = parfumerie.db";

        private CheckedListBox clbAccente;
        private float pretTotal = 0;

        Dictionary<Categorie, string> categorieDisplayStrings = new Dictionary<Categorie, string>
        {
            { Categorie.ApaDeToaleta, "Apa de toaleta" },
            { Categorie.ApaDeParfum, "Apa de parfum" },
            { Categorie.ApaDeColonie, "Apa de colonie" }
        };

        public AdaugaComandaForm(List<Accent> accente, List<Nota> note, List<Client> clienti, List<Comanda> comenzi)
        {
            InitializeComponent();
            this.accente = accente;
            this.note = note;
            this.clienti = clienti;
            this.comenzi = comenzi;

            InitializeComboBoxes();
            InitializeCheckedListBox();
        }

        private void InitializeComboBoxes()
        {
            cbCategorie.DataSource = new BindingSource(categorieDisplayStrings, null);
            cbCategorie.DisplayMember = "Value";
            cbCategorie.ValueMember = "Key";
            cbCategorie.SelectedIndex = -1;

            cbClient.DataSource = new List<Client>(clienti);
            cbClient.ValueMember = "NumeComplet";
            cbClient.SelectedIndex = -1;


            cbNota.DataSource = new List<Nota>(note);
            cbNota.DisplayMember = "Denumire";
            cbNota.SelectedIndex = -1;
        }

        private void InitializeCheckedListBox()
        {
            clbAccente = new CheckedListBox();
            clbAccente.ItemCheck += clbAccente_ItemCheck;
            Controls.Add(clbAccente);
            clbAccente.Visible = false;
        }
        private void AdaugaComandaForm_Load(object sender, EventArgs e)
        {
            clbAccente = new CheckedListBox();
            clbAccente.Name = "clbAccente";
            clbAccente.FormattingEnabled = true;
            clbAccente.CheckOnClick = true;

            foreach (Accent accent in accente)
            {
                clbAccente.Items.Add(accent.Denumire);
            }

            clbAccente.Visible = false;
        }

        private void toolStripDropDownButton1_DropDownClosed_1(object sender, EventArgs e)
        {
            clbAccente.Visible = false;
        }
        private void clbAccente_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateTotalPrice();
        }
        private void toolStripDropDownButton1_DropDownOpening(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear(); 
            foreach (Accent accent in accente)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(accent.Denumire);
                toolStripDropDownButton1.DropDownItems.Add(menuItem);
            }

            clbAccente.Visible = true;
            ToolStripControlHost host = new ToolStripControlHost(clbAccente);
            ToolStripDropDown dropDown = (sender as ToolStripDropDownButton).DropDown;
            dropDown.Items.Clear();
            dropDown.Items.Add(host);
            clbAccente.Location = new Point(toolStripDropDownButton1.Bounds.Left,
                toolStripDropDownButton1.Bounds.Bottom);
            dropDown.Show((sender as ToolStripDropDownButton).Owner, new Point((sender as ToolStripDropDownButton).Bounds.Left,
                (sender as ToolStripDropDownButton).Bounds.Bottom));
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
            {
                Comanda comanda = CreateComandaFromInput();
                AddComandaToDatabase(comanda);
                comenzi.Add(comanda);
                ClearInputFields();
            }
        }

        private bool InputIsValid()
        {
            return ValidatorComanda.ValidateInput(tbID, cbClient, cbCategorie, cbNota, clbAccente,
                toolStrip1, tbCantitate, errorProvider1, comenzi);
        }

        private void UpdateTotalPrice()
        {
            if (cbCategorie.SelectedItem != null && cbNota.SelectedItem != null && !string.IsNullOrWhiteSpace(tbCantitate.Text)
                && clbAccente.CheckedItems.Count > 0 && int.TryParse(tbCantitate.Text, out _))
            {
                float pretCategorie = (float)((Categorie)cbCategorie.SelectedValue);
                float pretNota = (float)((Nota)cbNota.SelectedItem).PretPerMl;
                int cantitate = int.Parse(tbCantitate.Text);
                float sumaPreturiAccente = 0;

                foreach (string accentDenumireString in clbAccente.CheckedItems)
                {
                    foreach (Accent accent in accente)
                    {
                        if (accent.Denumire == accentDenumireString)
                        {
                            sumaPreturiAccente += accent.PretPerMl;
                        }
                    }
                }

                pretTotal = cantitate * (0.5f * pretCategorie + 0.2f * pretNota + 0.3f * sumaPreturiAccente);
                tbPret.Text = pretTotal.ToString();
            }
            else
            {
                tbPret.Clear();
            }
        }

        private Comanda CreateComandaFromInput()
        {
            StringBuilder accenteStringBuilder = new StringBuilder();

            foreach (string accent in clbAccente.CheckedItems)
            {
                accenteStringBuilder.Append(accent);
                accenteStringBuilder.Append(", ");
            }

            string accenteString = accenteStringBuilder.ToString().TrimEnd(',', ' ');

            Comanda comanda = new Comanda
            {
                Id = int.Parse(tbID.Text),
                Data = DateTime.Now,
                Client = (Client)cbClient.SelectedItem,
                Categorie = (Categorie)cbCategorie.SelectedValue,
                Nota = (Nota)cbNota.SelectedItem,
                Accente = accenteString,
                CantitateInMl = int.Parse(tbCantitate.Text),
                Pret = pretTotal
            };

            return comanda;
        }

        private void AddComandaToDatabase(Comanda comanda)
        {
            string query = "INSERT INTO Comenzi(Id, Data, Client, Categorie, Nota, Accente, Cantitate, Pret) VALUES(@id, @data, @client, @categorie, @nota, @accente, @cantitate, @pret)";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", comanda.Id);
                    command.Parameters.AddWithValue("@data", DateTime.Now.ToString("g"));
                    command.Parameters.AddWithValue("@client", comanda.Client.Id);
                    command.Parameters.AddWithValue("@categorie", comanda.Categorie.ToString());
                    command.Parameters.AddWithValue("@nota", comanda.Nota.Id);
                    command.Parameters.AddWithValue("@accente", comanda.Accente);
                    command.Parameters.AddWithValue("@cantitate", comanda.CantitateInMl);
                    command.Parameters.AddWithValue("@pret", comanda.Pret);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ClearInputFields()
        {
            tbID.Clear();
            cbClient.SelectedIndex = -1;
            cbCategorie.SelectedIndex = -1;
            cbNota.SelectedIndex = -1;
            tbCantitate.Clear();
            tbPret.Clear();
            clbAccente.ClearSelected();
            foreach (int index in clbAccente.CheckedIndices)
            {
                clbAccente.SetItemChecked(index, false);
            }
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cbNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void tbCantitate_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnAfiseazaComenzi_Click(object sender, EventArgs e)
        {
            AfiseazaComenziForm afiseazaComenziForm = new AfiseazaComenziForm(comenzi);
            afiseazaComenziForm.ShowDialog();
        }
    }
}