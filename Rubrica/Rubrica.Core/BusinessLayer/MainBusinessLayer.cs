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
            iRepoContatti = repoContatti;
            iRepoIndirizzi = repoIndirizzi;
        }



    }
}
