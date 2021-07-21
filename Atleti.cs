using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioInterfacciaClasseAstratta_Mio_
{
    class Atleti
    { public string FirstName { get; set; }
        public string LastName { get; set; }
       public int Age { get; set; }

        // costruttore
        public Atleti( string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

    }
}
