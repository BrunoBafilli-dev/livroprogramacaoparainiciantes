/*
2 - Crie uma função chamada "verificarMaiorNumero" que recebe dois números como parâmetros e retorna o maior entre eles. 
Em seguida, chame a função com diferentes pares de números e imprima o maior valor retornado.
*/

/**************************Solução abaixo*********************************/

// Verifica se o primeiro número (num1) é maior que o segundo número (num2).
// Se sim, retorna num1; caso contrário, retorna num2.
int VerificarMaiorNumero(int num1, int num2)
{
    // Verifica se o primeiro número (num1) é maior que o segundo número (num2).
    // Se sim, retorna num1; caso contrário, retorna num2.
    return num1 > num2 ? num1 : num2;
}

// Chamando a função "VerificarMaiorNumero" com diferentes pares de números e armazenando os resultados em variáveis.
int resultado1 = VerificarMaiorNumero(10, 20);
int resultado2 = VerificarMaiorNumero(5, 15);
int resultado3 = VerificarMaiorNumero(100, 50);

// Imprimindo o maior valor retornado por cada chamada da função usando Console.WriteLine.
Console.WriteLine("O maior valor entre 10 e 20 é: " + resultado1);
Console.WriteLine("O maior valor entre 5 e 15 é: " + resultado2);
Console.WriteLine("O maior valor entre 100 e 50 é: " + resultado3);