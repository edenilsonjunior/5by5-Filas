using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            head = null;
            tail = null;
        }

        public void Enqueue(Pessoa aux)
        {
            if (IsEmpty())
            {
                head = aux;
                tail = aux;
            }
            else
            {
                tail.SetProximo(aux);
                tail = aux;
            }
        }

        public bool Dequeue()
        {
            if (!IsEmpty())
            {
                if (head == tail)
                    head = tail = null;
                else
                    head = head.GetProximo();

                return true;
            }
            return false;
        }

        public string Print()
        {
            string texto = "=============================\n";
            texto += "Conteudo da fila:\n";

            if (!IsEmpty()){
                Pessoa aux = head;
                do
                {
                    texto += $"--> {aux.GetNome()}\n";
                    aux = aux.GetProximo();
                } while (aux != null);
            }
            else
            {
                texto += "Fila vazia!";
            }
            return texto;
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
