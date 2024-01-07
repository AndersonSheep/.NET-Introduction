using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto7.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }

        public double Nota { get; set; }
        public override void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {Nome} anos, sou aluno.");
        }
    }
}