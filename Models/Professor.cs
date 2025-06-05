using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploExplorando.Models
{
    public sealed class Professor : Pessoa // Se a classe for selada ('sealed') esta não poderá ter nenhuma classe filha
    {
       
        public decimal Salario { get; set; }

        public sealed override void Apresentar() // Se for selado  ('sealed') a classe filha não podera sobrescrever o método 
        {
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade} anos. Sou professor e meu salário é: {Salario}");
        }
    }


}