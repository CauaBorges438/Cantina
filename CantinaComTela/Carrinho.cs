using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaComTela
{
    internal class Carrinho
    {

        private List<Cardapio> produtos = new List<Cardapio>();

        public void Adicionar(Cardapio novoProduto)
        {
            var existente = produtos.FirstOrDefault(p => p.Produto == novoProduto.Produto);
            if (existente != null)
            {
                existente.Quantidade += novoProduto.Quantidade;
            }
            else
            {
                produtos.Add(novoProduto);
            }
        }

        public void Remover(Cardapio produto)
        {
            produtos.Remove(produto);
        }
        public void Limpar()
        {
            produtos.Clear();
        }
        public double Total()
        {
            return produtos.Sum(p => p.Preco);
        }
        public List<Cardapio> ObterProdutos()
        {
            return produtos;
        }
    }
}

    
    


