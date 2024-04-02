using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parfumerie_WindowsFormsApp
{
    public class Comanda:IComparable<Comanda>
    {
        private int id;
        private DateTime data;
        private Client client;
        private Categorie categorie;
        private Nota nota;
        private string accente;
        private int cantitateInMl;
        private float pret;

        public Comanda(int id, DateTime data, Client client, Categorie categorie, Nota nota, string accente, int cantitateInMl, float pret)
        {
            this.id = id;
            this.data = data;
            this.client = client;
            this.categorie = categorie;
            this.nota = nota;
            this.accente = accente;
            this.cantitateInMl = cantitateInMl;
            this.pret = pret;
        }

        public Comanda()
        {
        }

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public Client Client { get => client; set => client = value; }
        public Categorie Categorie { get => categorie; set => categorie = value; }
        public Nota Nota { get => nota; set => nota = value; }
        public int CantitateInMl { get => cantitateInMl; set => cantitateInMl = value; }
        public float Pret { get => pret; set => pret = value; }
        public string Accente { get => accente; set => accente = value; }

        public int CompareTo(Comanda other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}