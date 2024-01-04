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
            foreach (Pessoa aluno in Alunos){
                System.Console.WriteLine(aluno.NomeCompleto);
            }
        }


        
    }
}