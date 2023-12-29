using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto4.Calculadora
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            System.Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair(int x, int y){
            System.Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multiplicar(int x, int y){
            System.Console.WriteLine($"{x} X {y} = {x*y}");
        }
        public void Dividir(int x, int y){
            System.Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Potencia(int x, int y){
            double resultado=Math.Pow(x,y);
            System.Console.WriteLine($"{x}^{y} = {resultado}");
        }
        public double Radiano(double angulo){
            double radiano = angulo * Math.PI / 180;
            return radiano;
        }
        public void Seno(double angulo){
            double resultado=Math.Sin(Radiano(angulo));
            System.Console.WriteLine($"Seno de {angulo}º = {Math.Round(resultado,4)}");
        }
        public void Coseno(double angulo){
            double resultado=Math.Cos(Radiano(angulo));
            System.Console.WriteLine($"Coseno de {angulo}º = {Math.Round(resultado,4)}");
        }
        public void Tangente(double angulo){
            double resultado=Math.Tan(Radiano(angulo));
            System.Console.WriteLine($"Tangente de {angulo}º = {Math.Round(resultado,4)}");
        }
        public void Raiz(double angulo){
            double resultado=Math.Sqrt(angulo);
            System.Console.WriteLine($"Raiz quadrada de {angulo} = {Math.Round(resultado,4)}");
        }
    }
}