﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        private readonly CorRepositorio repositorio = new CorRepositorio();

        [TestMethod()]
        public void LerTest()
        {
            var cores = repositorio.Ler();

            Assert.IsTrue(cores.Count > 0);
            Assert.IsTrue(cores.Any(c => c.Nome == "Branco"));
        }

        [TestMethod()]
        public void LerPorIdTest()
        {
            Assert.IsTrue(repositorio.Ler(1).Nome == "Preto");
            Assert.IsNull(repositorio.Ler(0));
        }

        [TestMethod()]
        public void SalvarTest()
        {
            var idRosa = repositorio.Salvar(new Cor { Nome = "Rosa" });
            Assert.IsTrue(repositorio.Ler(idRosa).Nome == "Rosa");
        }

        [TestMethod()]
        public void AtualizarTest()
        {
            var id = repositorio.Salvar(new Cor { Nome = "Magenta" });

            var magenta = repositorio.Ler(id);

            magenta.Nome = "Magenta Escuro";

            repositorio.Atualizar(magenta);

            magenta = repositorio.Ler(id);

            Assert.AreEqual(magenta.Nome, "Magenta Escuro");
            Assert.IsTrue(magenta.Nome == "Magenta Escuro");
        }

        [TestMethod()]
        public void ApagarTest()
        {
            repositorio.Apagar(5);
            Assert.IsNull(repositorio.Ler(5));
        }
    }
}