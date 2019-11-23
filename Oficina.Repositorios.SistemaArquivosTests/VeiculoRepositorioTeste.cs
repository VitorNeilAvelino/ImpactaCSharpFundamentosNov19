using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;

namespace Oficina.Repositorios.SistemaArquivosTests
{
    [TestClass]
    public class VeiculoRepositorioTeste
    {
        [TestMethod]
        public void InserirTeste()
        {
            var veiculo = new Veiculo();

            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Observacao = "Completinho";
            veiculo.Placa = "ABC1234";

            var corRepositorio = new CorRepositorio();

            veiculo.Cor = corRepositorio.Obter(1);

            veiculo.Modelo = new ModeloRepositorio().Obter(1);

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}
