using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome { 
            get => _nome.ToUpper();
            
            set{
                if(value==""){
                    throw new ArgumentException("O nome não pode esr vazio");
                }
                _nome = value;
            }
        }
        public int Idade { 
            get => _idade; 
            set{
                if (value<0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        private string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, \nTenho {Idade} anos");
        }
    }
}