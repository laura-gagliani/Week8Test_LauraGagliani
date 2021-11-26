using Rubrica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        List<Contatto> GetAllContatti();
        Esito AddContatto(string nome, string cognome);
        Contatto GetContattoById(int idContatto);
        Esito AddIndirizzo(Indirizzo i);
        Esito DeleteContatto(Contatto c);
    }
}
