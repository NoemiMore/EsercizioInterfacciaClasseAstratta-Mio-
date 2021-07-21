using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioInterfacciaClasseAstratta_Mio_
{
    class Difensore: Calciatore
    { public int RecuperiPalla { get; set; }

        public Difensore(string firstName, string lastName, int age, string ruolo, int maglia, int recuperiPalla) : base(firstName, lastName, age, ruolo, maglia)
        {
            RecuperiPalla = recuperiPalla;
                
        }
    }
}
