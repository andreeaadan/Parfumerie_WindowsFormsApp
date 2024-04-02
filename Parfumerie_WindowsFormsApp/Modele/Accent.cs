using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parfumerie_WindowsFormsApp
{
    public class Accent:IComparable<Accent>
    {
        private int id;
        private string denumire;
        private float pretPerMl;

        public Accent(int id, string denumire, float pretPerMl)
        {
            this.id = id;
            this.denumire = denumire;
            this.pretPerMl = pretPerMl;
        }

        public Accent()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public float PretPerMl { get => pretPerMl; set => pretPerMl = value; }

        public int CompareTo(Accent other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
