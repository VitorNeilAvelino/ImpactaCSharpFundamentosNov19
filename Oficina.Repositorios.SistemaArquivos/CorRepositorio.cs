﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        public List<Cor> Obter()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(@"Dados\Cor.txt"))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var cor = new Cor();

                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
            }

            return cores;
        }

        public Cor Obter(int id)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(@"Dados\Cor.txt"))
            {
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var linhaId = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaId)
                {
                    cor = new Cor();

                    cor.Id = linhaId;
                    cor.Nome = linha.Substring(5);

                    break;
                }                
            }

            return cor;
        }
    }
}
