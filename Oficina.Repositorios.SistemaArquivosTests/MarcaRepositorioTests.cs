using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();

        [TestMethod()]
        public void ObterTest()
        {
            var marcas = marcaRepositorio.Obter();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id} - {marca.Nome}");
            }
        }

        [TestMethod]
        public void ObterPorIdTeste()
        {
            var marca = marcaRepositorio.Obter(1);
            Assert.AreEqual(marca.Nome, "Fiat");

            marca = marcaRepositorio.Obter(0);
            Assert.IsNull(marca);
        }
    }
}