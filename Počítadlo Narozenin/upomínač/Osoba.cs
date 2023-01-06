using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upomínač
{
    public class Osoba
    {
        public string Jmeno { get; set; }
        public DateTime Narozeniny { get; set; }

        public Osoba(string jmeno, DateTime narozeniny)
        {
            Jmeno = jmeno;
            Narozeniny = narozeniny;
        }

        public int SpoctiVek()
        {
            DateTime dnes = DateTime.Today;
            int vek = dnes.Year - Narozeniny.Year;
            if (dnes < Narozeniny.AddYears(vek))
                vek--;
            return vek;
        }

        public override string ToString()
        {
            return Jmeno;
        }
    }
}
