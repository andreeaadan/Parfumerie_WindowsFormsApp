using System;

namespace Parfumerie_WindowsFormsApp
{
    public class Client:IComparable<Client>
    {
        private int id;
        private string nume;
        private string prenume;
        private string telefon;
        private string email;
        private string numeComplet;

        public Client(int id, string nume, string prenume, string telefon, string email)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.telefon = telefon;
            this.email = email;
        }

        public Client()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string NumeComplet { get => $"{Nume} {Prenume}"; }

        public int CompareTo(Client other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return NumeComplet;
        }
    }
}