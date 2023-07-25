/*
5 - Crie uma função chamada "calcularFatorial" que recebe um número inteiro como parâmetro e retorna o fatorial desse número. 
Use recursividade para implementar essa função. 
Em seguida, chame a função com um número de sua escolha e imprima o resultado.
*/

/**************************Solução abaixo*********************************/

int numeroEscolhido = 5; // Escolha um número para calcular o fatorial.

int resultado = CalcularFatorial(numeroEscolhido); // Chama a função para calcular o fatorial.

// Imprime o resultado.
Console.WriteLine($"O fatorial de {numeroEscolhido} é: {resultado}");

int CalcularFatorial(int numero)
{
    // Caso base: o fatorial de 0 é 1.
    if (numero == 0)
        return 1;

    // Chamada recursiva para calcular o fatorial.
    return numero * CalcularFatorial(numero - 1);
}
