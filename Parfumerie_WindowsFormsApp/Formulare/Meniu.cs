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
    public partial class Meniu : Form
    {
        private List<Nota> note = new List<Nota>();
        private List<Accent> accente = new List<Accent>();
        private List<Client> clienti = new List<Client>();
        private List<Comanda> comenzi = new List<Comanda>();
        private readonly string connectionString = "Data Source = parfumerie.db";
        public Meniu()
        {
            InitializeComponent();
        }

        void RetrieveNoteFromDB()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "SELECT * FROM Note";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string denumire = (string)reader["Denumire"];
                            float pretPerMl = Convert.ToSingle(reader["Pret"]);

                            Nota nota = new Nota(id, denumire, pretPerMl);
                            note.Add(nota);
                        }
                    }
                }
            }
        }

        void RetrieveClientiFromDB()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "SELECT * FROM Clienti";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string nume = (string)reader["Nume"];
                            string prenume = (string)reader["Prenume"];
                            string telefon = (string)reader["Telefon"];
                            string email = (string)reader["Email"];

                            Client client = new Client(id, nume, prenume, telefon, email);
                            clienti.Add(client);
                        }
                    }

                }
            }
        }

        void RetrieveAccenteFromDB()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "SELECT * FROM Accente";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string denumire = (string)reader["Denumire"];
                            float pretPerMl = Convert.ToSingle(reader["Pret"]); ;
                            Accent accent = new Accent(id, denumire, pretPerMl);
                            accente.Add(accent);
                        }
                    }
                }
            }
        }

        private void RetrieveComenziFromDB()
        {
            string query = "SELECT * FROM Comenzi";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            DateTime data = Convert.ToDateTime(reader["Data"]);
                            int idClient = Convert.ToInt32(reader["Client"]);
                            Categorie categorie = (Categorie)Enum.Parse(typeof(Categorie), reader["Categorie"].ToString());
                            int idNota = Convert.ToInt32(reader["Nota"]);
                            string accente = reader["Accente"].ToString();
                            int cantitate = Convert.ToInt32(reader["Cantitate"]);
                            float pret = Convert.ToSingle(reader["Pret"]);

                            Client client = null;
                            foreach (Client clientAux in clienti)
                            {
                                if (clientAux.Id == idClient)
                                {
                                    client = clientAux;
                                    break;
                                }
                            }

                            Nota nota = null;
                            foreach (Nota notaAux in note)
                            {
                                if (notaAux.Id == idNota)
                                {
                                    nota = notaAux;
                                    break;
                                }
                            }

                            Comanda comanda = new Comanda(id, data, client, categorie, nota, accente, cantitate, pret);
                            comenzi.Add(comanda);
                        }
                    }
                }
            }
        }
        private void Meniu_Load(object sender, EventArgs e)
        {
            RetrieveNoteFromDB();
            RetrieveAccenteFromDB();
            RetrieveClientiFromDB();
            RetrieveComenziFromDB();
        }

        private void btnAdaugaAccent_Click(object sender, EventArgs e)
        {
            AdaugaAccentForm adaugaAccentForm = new AdaugaAccentForm(accente);
            adaugaAccentForm.Show();
        }
        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            AdaugaClientForm adaugaClientForm = new AdaugaClientForm(clienti);
            adaugaClientForm.Show();
        }

        private void btnAdaugaNota_Click(object sender, EventArgs e)
        {
            AdaugaNotaForm adaugaNotaForm = new AdaugaNotaForm(note);
            adaugaNotaForm.Show();
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            AdaugaComandaForm adaugaComandaForm = new AdaugaComandaForm(accente, note, clienti, comenzi);
            adaugaComandaForm.ShowDialog();
        }
    }
}
