using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploExplorando.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome) // entendendo a herança e como definir um valor obrigatorio ao construir o método
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade} anos. Sou professor e meu salário é: {Salario}");
        }
    }


}