//7 - Crie uma lista com os números de 1 a 5 chamada "minhaLista". 
//Verifique o tamanho da lista e imprima o resultado.

/**************************Solução abaixo*********************************/

// Criar a lista "minhaLista" com os números de 1 a 5
List<int> minhaLista = new List<int>() { 1, 2, 3, 4, 5 };

// Verificar o tamanho da lista
int tamanhoLista = minhaLista.Count;

// Imprimir o tamanho da lista
Console.WriteLine($"Tamanho da lista: {tamanhoLista}");