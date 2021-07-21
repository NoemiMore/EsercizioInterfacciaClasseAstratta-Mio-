using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioInterfacciaClasseAstratta_Mio_
{
    class Portiere: Calciatore
    {
        
        public int GolSubiti { get; set; }

        public Portiere (string firstName, string lastName, int age, string ruolo, int maglia, int golSubiti) : base(firstName, lastName, age, ruolo, maglia)
        {
            GolSubiti = golSubiti;
        }
    }
}
