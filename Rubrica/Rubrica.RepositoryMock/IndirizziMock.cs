using Rubrica.Core.Entities;
using Rubrica.Core.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.RepositoryMock
{
    public class IndirizziMock : IRepositoryIndirizzi
    {
        public static List<Indirizzo> indirizzi = new List<Indirizzo>();

        public bool Add(Indirizzo item)
        {
            indirizzi.Add(item);
            return true;
        }

       

    }
}
