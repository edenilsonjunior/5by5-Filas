using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string nome)
        {
            this.nome = nome;
            proximo = null;
        }

        public string GetNome()
        {
            return nome;
        }

        public Pessoa? GetProximo()
        {
            return proximo;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetProximo(Pessoa proximo)
        {
            this.proximo = proximo;
        }

    }
}
