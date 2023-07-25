/*
4 - Crie uma lista com os números de 1 a 5 chamada "minhaLista". 
Verifique se o número 3 está presente na lista. Imprima o resultado.
*/

/**************************Solução abaixo*********************************/

// Criar a lista "minhaLista" com os números de 1 a 5
List<int> minhaLista = new List<int>() { 1, 2, 3, 4, 5 };

// Verificar se o número 3 está presente na lista
bool numeroPresente = minhaLista.Contains(3);

// Imprimir o resultado
if (numeroPresente){
    Console.WriteLine("O número 3 está presente na lista.");
}
else
{
    Console.WriteLine("O número 3 não está presente na lista.");
}