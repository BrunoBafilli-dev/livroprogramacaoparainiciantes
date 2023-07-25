/*
7 - Crie uma função chamada "processarLista" que recebe uma lista de números e uma função de callback como parâmetros. 
A função "processarLista" deve aplicar a função de callback a cada elemento da lista e imprimir o resultado. 
Em seguida, crie uma função de callback chamada "dobrarNumero" que recebe um número como parâmetro e retorna 
o dobro desse número. Chame a função "processarLista" passando uma lista de números e a função de callback "dobrarNumero".
*/

/**************************Solução abaixo*********************************/

// Criando uma lista de números.
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

// Chamando a função "processarLista" passando a lista de números e a função de callback "DobrarNumero".
ProcessarLista(numeros, DobrarNumero);

// Chamando a função "processarLista" passando a lista de números e a função de callback "dobrarNumero".
ProcessarLista(numeros, DobrarNumero);

// Função de callback que recebe um número e imprime o dobro dele.
void DobrarNumero(int numero)
{
    int resultado = numero * 2;
    Console.WriteLine($"O dobro de {numero} é: {resultado}");
}

// Função "processarLista" que recebe uma lista de números e uma função de callback.
void ProcessarLista(List<int> lista, Action<int> callback)
{
    foreach (int numero in lista)
    {
        // Chama a função de callback, passando o número atual da lista.
        callback(numero);
    }
}