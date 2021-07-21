using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioInterfacciaClasseAstratta_Mio_
{
    class Calciatore: Atleti
    {    enum Ruolo 
        public int Maglia { get; set; }

        //costruttore
        public Calciatore (string firstName, string lastName, int age, enum ruolo, int maglia): base (firstName, lastName, age)
            {
           Ruolo = ruolo;
            Maglia = maglia;
        }

       
    }
}
