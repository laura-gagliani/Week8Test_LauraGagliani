﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica.Core.Entities
{
    public class Contatto
    {
        public int IdContatto { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public List<Indirizzo> Indirizzi { get; set; } = new List<Indirizzo>();


        

        public override string ToString()
        {
            return $"Id: {IdContatto} - Nome: {Nome} {Cognome} - Indirizzi associati: {Indirizzi.Count}";
        }

    }
}
