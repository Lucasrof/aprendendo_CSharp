using ExemploExplorando.Models;
using System.Globalization;
using System.Text;

Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
Console.OutputEncoding = Encoding.UTF8;

Aluno a1 = new Aluno();
a1.Nome = "Lucas";
a1.Idade = 27;
a1.Email = "teste@gmail.com";
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Luiz Antonio";
p1.Idade = 55;
p1.Salario = 10000;
p1.Apresentar();

