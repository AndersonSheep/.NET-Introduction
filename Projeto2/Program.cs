// Importanto uma classe
using Projeto2.Models;
// Iniciando uma classe
Pessoa pessoa1 = new()
{
    Nome = "Dinho",
    Idade = 29,
    Sobrenome = "Carneiro"
};
pessoa1.Apresentar();

// Metodo DateTime
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));

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

// Formatação de números
decimal valorMonetario = 10;
System.Console.WriteLine($"{valorMonetario:C}");
System.Console.WriteLine(valorMonetario.ToString("N2"));
System.Console.WriteLine(valorMonetario.ToString("P"));
System.Console.WriteLine(valorMonetario.ToString("#-#"));
// C = valor monetário, N = valor decimal, P = porcentagem, #-##-## = valores personalisados

// Espera o usuário digitar um comando Console.ReadLine()
System.Console.WriteLine("Digite uma letra: ");
//string letra = Console.ReadLine();

Pessoa p1 = new()
{
    Nome = "momo",
    Idade = 25,
    Sobrenome = "debora"
};

Pessoa p2 = new()
{
    Nome = "kally",
    Idade = 8,
    Sobrenome = "up"
};

Curso cursoDeIngles = new(){
    Nome = "Ingles",
    Alunos = new List<Pessoa>()
};

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();