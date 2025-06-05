using aprendendo_CSharp.Models;
using ExemploExplorando.Models;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
Console.OutputEncoding = Encoding.UTF8;

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

Pessoa p1 = new Pessoa("Lucas");
Aluno a1 = new Aluno("Lucas R");
a1.Apresentar();