// See https://aka.ms/new-console-template for more information
using System.Globalization;
string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}