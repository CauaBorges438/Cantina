using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaComTela
{
    internal class Pedido
    {

        public string Cliente { get; set; }
        public string Itens { get; set; }
        public string ParaViagem { get; set; }
        public string Status { get; set; }
        public string Hora { get; set; } //= DateTime.Now.ToShortTimeString();

        public override string ToString()
        {
            return $"{Hora} - {Cliente} - {Itens} - Viagem: {ParaViagem} {Status}";
        }

        public static class BaseDePedidos
        {
            public static List<Pedido> Pedidos = new List<Pedido>();
            
        }
    }
}

