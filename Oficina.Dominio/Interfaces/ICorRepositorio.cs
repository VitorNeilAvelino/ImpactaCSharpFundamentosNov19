using System.Collections.Generic;

namespace Oficina.Dominio.Interfaces
{
    public interface ICorRepositorio
    {
        int Salvar(Cor cor);
        Cor Ler(int id);
        List<Cor> Ler();
        void Apagar(int id);
        void Atualizar(Cor cor);
    }
}