// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id:{venda.Id}, Produto:{venda.Produto}, Preço: {venda.Preco}");
}










/* 
List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de software", 110.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);]
*/