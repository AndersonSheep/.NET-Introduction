using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2.Models
{
    public class Curso
    {
        public string Nome {get; set;}
        public List<Pessoa> Alunos {get;set;}

        public void AdicionarAluno (Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int QuantidadeDeAlunos(){
            int quatidade = Alunos.Count;
            return quatidade;
        }

        public void RemoverAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            System.Console.WriteLine($"Alunos do curso de: {Nome}");
            for(int count = 0; count < Alunos.Count; count++){
                string texto = "Nº" + count + " - " + Alunos[count].NomeCompleto;   
                System.Console.WriteLine(texto);
            }
        }


        
    }
}