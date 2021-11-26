using Rubrica.Core.BusinessLayer;
using Rubrica.Core.Entities;
using Rubrica.RepositoryADO;
using Rubrica.RepositoryMock;
using System;
using System.Collections.Generic;

namespace Rubrica.ConsoleApp
{
    class Program
    {
        //private static readonly IBusinessLayer bl = new MainBusinessLayer(new ContattiMock(), new IndirizziMock());
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new ContattiADO(), new IndirizziADO());

        static void Main(string[] args)
        {
            bool quit = false;
            int choice;

            do
            {
                Console.WriteLine("---------- MENU RUBRICA ----------");
                Console.WriteLine("[1] Visualizza tutti i contatti");
                Console.WriteLine("[2] Aggiungi nuovo contatto");
                Console.WriteLine("[3] Aggiungi indirizzo");
                Console.WriteLine("[4] Elimina contatto");
                Console.WriteLine("[0] Chiudi");

                choice = GetMenuInt(0, 4);

                switch (choice)
                {
                    case 1:
                        VisualizzaContatti();
                        break;
                    case 2:
                        AggiungiContatto();
                        break;
                    case 3:
                        AggiungiIndirizzo();
                        break;
                    case 4:
                        EliminaContatto();
                        break;
                    case 0:
                        quit = true;
                        Console.WriteLine("\nChiusura in corso...");
                        break;
                }

            } while (!quit);
        }

        private static void EliminaContatto()
        {
            Console.WriteLine("\nQuale contatto vuoi rimuovere dalla rubrica?");
            VisualizzaContatti();
            Console.WriteLine("Digita l'ID del contatto prescelto:");
            int idContatto = GetInt();

            Contatto c = bl.GetContattoById(idContatto);

            if (c.Nome != null && c.Cognome != null)
            {
                Esito e = bl.DeleteContatto(c);
                Console.WriteLine(e.Messaggio);

            }
            else
                Console.WriteLine("Errore! Nessun contatto trovato con questo ID");

        }

        private static void AggiungiIndirizzo()
        {
            Console.WriteLine("\nA quale contatto desideri associare il nuovo indirizzo?");
            VisualizzaContatti();
            Console.WriteLine("Digita l'ID del contatto prescelto:");
            int idContatto = GetInt();

            Contatto c = bl.GetContattoById(idContatto);

            if (c != null)
            {
                Indirizzo i = new Indirizzo();
                i.Contatto = c;
                i.IdContatto = c.IdContatto;
                

                Console.WriteLine("\n----Inserimento Dati----");
                Console.Write("Tipologia: ");
                i.Tipologia = Console.ReadLine();
                Console.Write("Via: ");
                i.Via = Console.ReadLine();
                Console.Write("Città: ");
                i.Citta = Console.ReadLine();
                Console.Write("CAP: ");
                i.CAP = GetInt();
                Console.Write("Provincia: ");
                i.Provincia = Console.ReadLine();
                Console.Write("Nazione: ");
                i.Nazione = Console.ReadLine();
                Console.WriteLine("-------------------------\n");

                Esito aggiunta = bl.AddIndirizzo(i);
                Console.WriteLine(aggiunta.Messaggio);

            }
            else
                Console.WriteLine("Errore! Nessun contatto trovato con questo ID");

        }

        private static int GetInt()
        {
            bool parse;
            int choice;
            do
            {
                parse = int.TryParse(Console.ReadLine(), out choice);
            } while (!parse);
            return choice;
        }

        private static void AggiungiContatto()
        {
            Console.WriteLine("\n----Inserimento Dati----");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("-------------------------\n");

            Esito esito = bl.AddContatto(nome, cognome);
            Console.WriteLine(esito.Messaggio);

        }

        private static void VisualizzaContatti()
        {
            List<Contatto> contatti = bl.GetAllContatti();

            Console.WriteLine("\nContatti in rubrica:");
            if (contatti.Count == 0)
            {
                Console.WriteLine(" - Nessun contatto - ");
            }
            else
            {
                foreach (var item in contatti)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("\n");

            }


        }

        private static int GetMenuInt(int min, int max)
        {
            bool parse;
            int choice;
            do
            {
                parse = int.TryParse(Console.ReadLine(), out choice);
            } while (!(parse && choice >= min && choice <= max));
            return choice;
        }
    }
}
