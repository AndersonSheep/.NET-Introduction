using Projeto7.Models;
using Projeto7.Interfaces;

Pessoa p1 = new("eu");
p1.Nome="eu";
p1.Idade=2;
p1.Apresentar();

ContaCorrent c1 = new ContaCorrent(123,1000);
c1.ExibirSaldo();
c1.Sacar(200);
c1.ExibirSaldo();

Aluno a1 = new("ele");
a1.Nome="ele";
a1.Idade=3;
a1.Nota=10;
a1.Apresentar();

Professor prof = new Professor("dyud");
prof.Nome="dyud";
prof.Idade=26;
prof.Apresentar();

Corrente c = new();
c.Creditar(900);
c.ExibirSaldo();

ICalculadora calc = new Calculadora();
calc.Somar(2,2);