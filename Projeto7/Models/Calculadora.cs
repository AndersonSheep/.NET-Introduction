using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto7.Interfaces;

namespace Projeto7.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int x, int y){
            System.Console.WriteLine($"{x} + {y} = {x+y}");
            return x+y;
        }
        public int Subtrair(int x, int y){
            System.Console.WriteLine($"{x} - {y} = {x-y}");
            return x-y;
        }
        public int Multiplicar(int x, int y){
            System.Console.WriteLine($"{x} X {y} = {x*y}");
            return x*y;
        }
        public int Dividir(int x, int y){
            System.Console.WriteLine($"{x} / {y} = {x/y}");
            return x/y;
        }
    }
}