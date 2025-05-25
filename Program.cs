using ExemploExplorando.Models;
using System.Globalization;

try
{

    string[] linhas = File.ReadAllLines("Arquivos/pasta1/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. O caminho da pasta não foi encontrado."
    + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui!");
}


