using Rubrica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.Core.RepoInterfaces
{
    public interface IRepositoryContatti :IRepository<Contatto>
    {
        List<Contatto> GetAll();
        Contatto GetById(int idContatto);
        bool Delete(Contatto c);
    }
}
