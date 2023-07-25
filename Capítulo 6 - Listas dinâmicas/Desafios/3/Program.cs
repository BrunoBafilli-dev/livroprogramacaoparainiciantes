/*
3 - Crie uma lista com os números de 1 a 5 chamada "minhaLista". 
Acesse o primeiro elemento da lista e imprima-o.
*/

/**************************Solução abaixo*********************************/

// Criar a lista "minhaLista" com os números de 1 a 5
List<int> minhaLista = new List<int>() { 1, 2, 3, 4, 5 };

// Acessar o primeiro elemento da lista e imprimir seu valor
int primeiroElemento = minhaLista[0];
Console.WriteLine("Primeiro elemento da lista: " + primeiroElemento);