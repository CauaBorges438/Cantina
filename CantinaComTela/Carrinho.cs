using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaComTela
{
    internal class Carrinho
    {
        private string formaPgto;
        private string nome;
        //public List<Cardapio> pedidos = new List<Cardapio>();
        private string status;
        private string obterProduto;

        public string ObterProduto
        {
            get { return obterProduto; }
            set { obterProduto = value; }

        }
        public string FormaPgto
        { get { return formaPgto; } set { formaPgto = value; } }

        public string Nome
        { get { return nome; } set { nome = value; } }

        public string Status { get { return status; } set { status = value; } }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append($"Cliente: {nome} ");
        //    foreach (Cardapio cardapio in pedidos)
        //    {
        //        sb.Append($"/ {cardapio.Quantidade}x - {cardapio.Produto}");
        //    }
        //    return sb.ToString();
        //}
        public static class BaseDados
        {
            public static List<Carrinho> pedidos = new List<Carrinho>();
        }
    }
}
    
    


