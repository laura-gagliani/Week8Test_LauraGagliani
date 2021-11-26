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

        public List<Indirizzo> GetByIdContatto(int idContatto)
        {
            List<Indirizzo> indirizziContatto = new List<Indirizzo>();

            foreach (var item in indirizzi)
            {
                if (item.IdContatto == idContatto)
                {
                    indirizziContatto.Add(item);
                }
            }
            return indirizziContatto;
        }

    }
}
