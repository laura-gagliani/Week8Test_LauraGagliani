using Rubrica.Core.BusinessLayer;
using Rubrica.Core.Entities;
using Rubrica.RepositoryMock;
using System;
using System.Collections.Generic;

namespace Rubrica.ConsoleApp
{
    class Program
    {
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new ContattiMock(), new IndirizziMock());

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
            throw new NotImplementedException();
        }

        private static void AggiungiIndirizzo()
        {
            throw new NotImplementedException();
        }

        private static void AggiungiContatto()
        {
            throw new NotImplementedException();
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
