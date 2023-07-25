/*
5 - Crie um programa que solicite ao usuário um número inteiro positivo e 
calcule a soma de todos os números pares de 1 até o número fornecido. Exiba o resultado da soma.
*/

/**************************Solução abaixo*********************************/

// Solicitar ao usuário que insira um número inteiro positivo
Console.Write("Digite um número inteiro positivo: ");

// Ler o número digitado pelo usuário e armazená-lo em uma variável
int numero = Convert.ToInt32(Console.ReadLine());

// Variável para armazenar a soma dos números pares
int somaPares = 0;

// Calcular a soma dos números pares de 1 até o número fornecido pelo usuário
for (int i = 1; i <= numero; i++)
{
    // Verificar se o número atual (i) é par (resto da divisão por 2 é igual a 0)
    if (i % 2 == 0)
    {
        // Se o número é par, adicioná-lo à soma
        somaPares += i;
    }
}

// Exibir o resultado da soma dos números pares
Console.WriteLine("A soma dos números pares de 1 até " + numero + " é: " + somaPares);