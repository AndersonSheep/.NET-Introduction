using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto7.Models
{
    public class Pessoa
    {
        public Pessoa(){
            
        }
        public Pessoa(string nome){
            Nome=nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string emai { get; set; }

        public virtual void Apresentar(){
            System.Console.WriteLine($"Olá meu nome é {Nome} e trenho {Idade} anos!");
        }
    }
}