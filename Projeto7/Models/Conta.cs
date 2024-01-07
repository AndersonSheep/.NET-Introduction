using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto7.Models
{
    public abstract class Conta
    {
        protected decimal saldo;
        public abstract void Creditar(decimal valor);
        public void ExibirSaldo(){
            System.Console.WriteLine($"Seu saldo é {saldo}");
        }
        
    }
}