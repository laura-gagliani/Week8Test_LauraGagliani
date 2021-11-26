using Rubrica.Core.Entities;
using Rubrica.Core.RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryContatti repoContatti;
        private readonly IRepositoryIndirizzi repoIndirizzi;

        //costruttore mbl che associa le Irepo
        public MainBusinessLayer(IRepositoryContatti iRepoContatti, IRepositoryIndirizzi iRepoIndirizzi)
        {
            repoContatti = iRepoContatti;
            repoIndirizzi = iRepoIndirizzi;
        }





        public Esito AddContatto(string nome, string cognome)
        {
            Contatto newContatto = new Contatto();
            newContatto.Nome = nome;
            newContatto.Cognome = cognome;

            bool isAdded = repoContatti.Add(newContatto);

            if (isAdded)
                return new Esito { Messaggio = "Contatto aggiunto alla rubrica", isOk = true };
            else
                return new Esito { Messaggio = "Errore nella procedura di aggiunta", isOk = false };
        }

        public Esito AddIndirizzo(Indirizzo i)
        {
            bool isAdded = repoIndirizzi.Add(i);

            if (isAdded)
                return new Esito { Messaggio = "Indirizzo inserito in rubrica", isOk = true };
            else
                return new Esito { Messaggio = "Errore nell'inserimento", isOk = false };

        }

        public Esito DeleteContatto(Contatto c)
        {
            List<Indirizzo> indirizziUtente = repoIndirizzi.GetByIdContatto(c.IdContatto);
            if (indirizziUtente.Count == 0)
            {
                repoContatti.Delete(c);
                return new Esito { Messaggio = "Contatto eliminato dalla rubrica", isOk = true };
            }
            else
                return new Esito { Messaggio = "Errore! Impossibile eliminare contatti con indirizzi associati", isOk = false };
        }

        public List<Contatto> GetAllContatti()
        {
            return repoContatti.GetAll();

        }

        public Contatto GetContattoById(int idContatto)
        {
            return repoContatti.GetById(idContatto);

            
        }
    }
}
