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
        string json = JsonSerializer.Serialize(pedidos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(caminho, json);
    }

    public static List<Pedido> Carregar()
    {
        if (!File.Exists(caminho))
            return new List<Pedido>();

        string json = File.ReadAllText(caminho);
        return JsonSerializer.Deserialize<List<Pedido>>(json);
    }
}
}

