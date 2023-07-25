/*
4 - Escreva um programa que faça uma contagem regressiva a partir de um número fornecido 
pelo usuário até zero. Em cada iteração, o programa deve exibir o número atual da contagem.
*/

/**************************Solução abaixo*********************************/

// Solicitar ao usuário que insira o número inicial da contagem regressiva
Console.Write("Digite um número para iniciar a contagem regressiva: ");

// Ler o número digitado pelo usuário e armazená-lo em uma variável
int numeroInicial = Convert.ToInt32(Console.ReadLine());

// Realizar a contagem regressiva utilizando o loop for
for (int i = numeroInicial; i >= 0; i--)
{
    // Exibir o número atual da contagem
    Console.WriteLine(i);
}