using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.Core.RepoInterfaces
{
    public interface IRepository<T>
    {
        T Add(T item);
    }
}
