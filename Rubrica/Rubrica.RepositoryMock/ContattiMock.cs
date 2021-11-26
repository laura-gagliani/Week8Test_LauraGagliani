using Rubrica.Core.Entities;
using Rubrica.Core.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.RepositoryMock
{
    public class ContattiMock : IRepositoryContatti
    {
        public static List<Contatto> contatti = new List<Contatto>()
        {
            new Contatto{IdContatto = 1, Nome = "Mario", Cognome = "Rossi"},
            new Contatto{IdContatto = 2, Nome = "Sara", Cognome = "Bianchi"},
            new Contatto{IdContatto = 3, Nome = "Luca", Cognome = "Verdi"},

        };

        public Contatto Add(Contatto item)
        {
            throw new NotImplementedException();
        }

        public List<Contatto> GetAll()
        {
            return contatti;
        }
    }
}
