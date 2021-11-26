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
        public Contatto Add(Contatto item)
        {
            throw new NotImplementedException();
        }

        public List<Contatto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
