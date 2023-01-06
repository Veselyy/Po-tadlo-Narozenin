using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upomínač
{
    public class SprávceOsob
    {
        public BindingList<Osoba> Osoby { get; set; }

        public SprávceOsob()
        {
            Osoby = new BindingList<Osoba>();
        }
        public void Pridej(string jmeno, DateTime datumNarozeni)
        {
            if (jmeno.Length < 3)
                throw new ArgumentException("Jméno je příliš krátké.");
            if (datumNarozeni.Date > DateTime.Today)
                throw new ArgumentException("Datum narození nesmí být v budoucnosti.");
            Osoba osoba = new Osoba(jmeno, datumNarozeni.Date);
            Osoby.Add(osoba);
        }

        public void Odeber(Osoba osoba)
        {
            Osoby.Remove(osoba);
        }

    }
}
