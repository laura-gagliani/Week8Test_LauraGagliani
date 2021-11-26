using Rubrica.Core.BusinessLayer;
using Rubrica.RepositoryMock;
using System;
using Xunit;

namespace Rubrica.Test
{
    public class AggiuntaTest
    {
        [Fact]
        public void Test1()
        {
            //arrange
            IBusinessLayer bl = new MainBusinessLayer(new ContattiMock(), new IndirizziMock());
            int countIniziale = ContattiMock.contatti.Count;
            //act 
            bl.AddContatto("nome", "cognome");

            //assert
            Assert.Equal(countIniziale, ContattiMock.contatti.Count);

        }
    }
}
