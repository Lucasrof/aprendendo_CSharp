using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int QuantidadeAlunos = Alunos.Count;
            return QuantidadeAlunos;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {

                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto; CONCATENAÇÂO
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; // INTERPOLAÇÃO
                Console.WriteLine(texto);
            }
        }
    }
}