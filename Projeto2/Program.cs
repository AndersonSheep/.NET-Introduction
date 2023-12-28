using Projeto2.Models;
Pessoa pessoa1 = new()
{
    Nome = "Dinho",
    Idade = 29
};

pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyy"));