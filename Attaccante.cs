using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioInterfacciaClasseAstratta_Mio_
{
    class Attaccante: Calciatore
    {
        public int GolFatti { get; set; }

        public Attaccante (string firstName, string lastName, int age, string ruolo, int maglia, int golFatti) : base(firstName, lastName, age, ruolo, maglia)
        {
            GolFatti = golFatti;
        }
    }
}
