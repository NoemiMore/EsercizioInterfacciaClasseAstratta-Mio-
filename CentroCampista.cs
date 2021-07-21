using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioInterfacciaClasseAstratta_Mio_
{
    class CentroCampista: Calciatore
    { public int NumAssist { get; set; }


        public CentroCampista(string firstName, string lastName, int age, string ruolo, int maglia, int numAssist) : base(firstName, lastName, age, ruolo, maglia)
        {
            NumAssist= numAssist;

        }
    }
}
