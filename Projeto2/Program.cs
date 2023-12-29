// Importanto uma classe
using Projeto2.Models;
// Iniciando uma classe
Pessoa pessoa1 = new()
{
    Nome = "Dinho",
    Idade = 29
};
pessoa1.Apresentar();

// Metodo DateTime
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyy"));

// Metodo de conversão de valores Convert e Parse
int a = Convert.ToInt32("5");
int b = int.Parse("5");

// Metodo para converter pra string ToString()
string c = a.ToString();

// Metodo para pegar o valor máximo de um tipo
int d = int.MaxValue;

// TryParse, metodo para verificar antes de converter
string e = "9-";
int.TryParse(e, out a);

// Espera o usuário digitar um comando Console.ReadLine()
System.Console.WriteLine("Digite uma letra: ");
//string letra = Console.ReadLine();