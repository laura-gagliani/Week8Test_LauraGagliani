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

        public bool Add(Contatto item)
        {
            item.IdContatto = GenerateId();
            contatti.Add(item);
            return true;
        }

        private int GenerateId()
        {
            if (contatti.Count == 0)
            {
                return 1;
            }
            else
            {
                int max =0;
                foreach (var item in contatti)
                {
                    if (item.IdContatto > max)
                    {
                        max = item.IdContatto;
                    }
                }
                max++;
                return max;
            }
        }

        public List<Contatto> GetAll()
        {
            return contatti;
        }

        public Contatto GetById(int idContatto)
        {
            foreach (var item in contatti)
            {
                if (item.IdContatto == idContatto)
                {
                    return item;
                }
            }
            return null;
        }

        public bool Delete(Contatto c)
        {
            contatti.Remove(c);
            return true;
        }
    }
}
