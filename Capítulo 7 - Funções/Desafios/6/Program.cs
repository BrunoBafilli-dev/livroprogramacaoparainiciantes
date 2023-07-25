/*
6 - Crie uma função chamada "calcularMedia" que recebe um array de números como parâmetro e retorna a média desses números. 
Em seguida, crie um array de números e chame a função para calcular a média, imprimindo o resultado.
*/

/**************************Solução abaixo*********************************/

// Criando um array de números para calcular a média.
int[] numeros = { 10, 20, 30, 40, 50 };

// Chamando a função para calcular a média do array de números.
double media = CalcularMedia(numeros);

// Imprimindo o resultado da média no console.
Console.WriteLine($"A média dos números é: {media}");

 static double CalcularMedia(int[] numeros)
{
    if (numeros == null || numeros.Length == 0)
    {
        return 0; // Retornar 0 se o array de números estiver vazio ou nulo.
    }

    int soma = 0;
    foreach (int numero in numeros)
    {
        soma += numero;
    }

    return (double)soma / numeros.Length;
}