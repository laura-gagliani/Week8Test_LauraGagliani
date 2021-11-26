using Rubrica.Core.BusinessLayer;
using Rubrica.RepositoryMock;
using System;


namespace Rubrica.ConsoleApp
{
    class Program
    {
        private readonly IBusinessLayer bl = new MainBusinessLayer(new ContattiMock(), new IndirizziMock());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
