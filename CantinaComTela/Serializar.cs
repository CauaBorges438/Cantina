using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CantinaComTela
{
    internal class Serializar
    {
        private static string caminho = "pedidos.json";

        public static void Salvar(List<Pedido> pedidos)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new System.Text.Json.Serialization.JsonStringEnumConverter() }
            };

            string json = JsonSerializer.Serialize(pedidos, options);
            File.WriteAllText(caminho, json);
        }

        public static List<Pedido> Carregar()
        {
            if (!File.Exists(caminho))
                return new List<Pedido>();

            string json = File.ReadAllText(caminho);

            var options = new JsonSerializerOptions
            {
                Converters = { new System.Text.Json.Serialization.JsonStringEnumConverter() }
            };

            return JsonSerializer.Deserialize<List<Pedido>>(json, options);
        
        }
        public static List<Pedido> CarregarUltimosPedidos()
        {
            List<Pedido> todosPedidos = Carregar();
            return todosPedidos.TakeLast(5).ToList();

        }

    }
}

