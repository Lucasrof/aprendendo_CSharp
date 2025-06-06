using aprendendo_CSharp.Models;
using ExemploExplorando.Models;
using System.Globalization;
using ExemploExplorando.Interfaces;
using System.Text;


Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
Console.OutputEncoding = Encoding.UTF8;

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));
