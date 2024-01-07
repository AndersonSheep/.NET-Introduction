using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto7.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public double Salario { get; set; }
        public override void Apresentar(){
            System.Console.WriteLine($"Olá, sou {Nome} e sou um professor");
        }
    }
}