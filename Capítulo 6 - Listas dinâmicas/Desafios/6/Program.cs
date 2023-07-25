//6 - Crie uma lista com os números de 1 a 5 chamada "minhaLista". 
//Itere sobre a lista e imprima cada elemento em uma linha separada.

/**************************Solução abaixo*********************************/

// Criar a lista "minhaLista" com os números de 1 a 5
List<int> minhaLista = new List<int>() { 1, 2, 3, 4, 5 };

// Iterar sobre a lista e imprimir cada elemento em uma linha separada
Console.WriteLine("Elementos da lista:");
foreach (int numero in minhaLista)
{
    Console.WriteLine(numero);
}