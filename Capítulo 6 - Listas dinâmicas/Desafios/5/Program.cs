//5 - Crie uma lista com os números de 1 a 5 chamada "minhaLista". 
//Remova o número 3 da lista. Imprima a lista para verificar se o elemento foi removido corretamente.

/**************************Solução abaixo*********************************/

// Criar a lista "minhaLista" com os números de 1 a 5
List<int> minhaLista = new List<int>() { 1, 2, 3, 4, 5 };

// Remover o número 3 da lista
minhaLista.Remove(3);

// Imprimir a lista após a remoção
Console.WriteLine("Lista após remover o número 3:");
foreach (int numero in minhaLista)
{
    Console.WriteLine(numero);
}