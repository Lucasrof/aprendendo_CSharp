using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            SobreNome = sobrenome;
        }
        private string _nome;
        private string _sobreNome;
        private int _idade;
        
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public string SobreNome
        {
            get => _sobreNome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                _sobreNome = value;
             }
        }
        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor do que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
        
    }
}