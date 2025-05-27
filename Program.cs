using aprendendo_CSharp.Models;
using ExemploExplorando.Models;
using System.Globalization;
using System.Runtime.InteropServices;

// Entendendo a Fila:
Queue<int> fila = new Queue<int>();
// Inserindo elemento na fila 'Enqueue'
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

//Removedo elemento na fila 'Dequeue'

Console.WriteLine($"\nRemovento o elemento da FILA: {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}


// Entendo a pilha
Stack<int> pilha = new Stack<int>();
// Adicionando elementos na pilha 'push'
Console.WriteLine($"\nEntendendo o funcionamento da pilha (inserindo): ");
pilha.Push(10);
pilha.Push(20);
pilha.Push(30);
pilha.Push(40);

foreach (int item in pilha) 
{
    Console.WriteLine(item);
}
// Removendo elementos da pilha 'pop'
Console.WriteLine($"\nRemovendo o elemento do topo da PILHA: {pilha.Pop()}");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

// Entendndo o dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();
// Adicionando elemento ao dictionary ADD
Console.WriteLine($"\nInserindo valores no dictionary 'Add': ");
estados.Add("SP", "São Paulo");
estados.Add("GO", "Goiás");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

// Removendo elemento do dictionary REMOVE
Console.WriteLine("\nRevomento a chave 'BA' do dictionary com .Remove:");
estados.Remove("BA");
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

// Alterando o valor do elemento do dictionary
estados["GO"] = "Goiás - GO";
Console.WriteLine("\nInserindo um novo valor para a chave 'GO':");
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

// Verificando se há uma chave no dictionary
Console.WriteLine("\nVerificando se há uma chave existente no disctionary:");
string chave = "GO";
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor de chave existente: {chave}, insira outra chave!");
}
else
{
    Console.WriteLine($"Valor de chave inexistente no disctionary, é seguro adicionar a chave: {chave}");
}
