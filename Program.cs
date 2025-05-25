using ExemploExplorando.Models;
using System.Globalization;

DateTime data = DateTime.Now;
Console.WriteLine("Utilizando o DateTime: ");
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm\n"));

Console.WriteLine("Utilizando o DateTime.Parse: ");
DateTime data2 = DateTime.Parse("19/04/2022 18:27");
Console.WriteLine(data2+"\n");

Console.WriteLine("Utilizando o DateTime.TryParseExact: ");
string dataString = "2022-01-27 17:00";
// Entendendo o tryparse e TryParseExact
DateTime.TryParseExact(dataString,
                       "yyyy-MM-dd HH:mm",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out DateTime data4);
Console.WriteLine(data4+"\n");

// If/Else para entender o bool do DateTime.TryParseExact

bool sucesso = DateTime.TryParseExact(dataString,
                       "yyyy-MM-dd HH:mm",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out DateTime data5);
if (sucesso)
{
    Console.WriteLine($"Data convertida com sucesso!! Data: {data5}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida, verifique!!");
}
