using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaComTela
{
    internal class Cardapio
    {
        private string produto;
        private double preco;
        private int quantidade;
        private bool isChapa;
        //private Status status;

        public Cardapio(string produto, double preco, bool isChapa)
        {
            this.produto = produto;
            this.preco = preco;
            this.quantidade = 0;
            this.isChapa = isChapa;

            
                
        }

        public bool IsChapa
        { get { return isChapa; } }
        public string Produto
        {
            get { return produto; }
        }

        public double Preco
            { get { return preco; }
              set { preco = value; }
            }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        

        public override string ToString()
        {
            if(quantidade>0)
                return $"{quantidade}x - {produto} - R$ {preco:f2}";
            else
                return $"{produto} - R$ {preco:f2}";
        }
    }
}
