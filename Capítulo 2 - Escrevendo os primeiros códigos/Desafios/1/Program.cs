// 1 - Escreva um programa que solicite ao usuário um número e exiba a mensagem 
// "Número par" se o número for par, ou "Número ímpar" se for ímpar.

/**************************Solução abaixo*********************************/

// Solicitar ao usuário que insira um número
Console.Write("Digite um número: ");

// Ler o número digitado pelo usuário e armazená-lo em uma variável
int numero = Convert.ToInt32(Console.ReadLine());

// Verificar se o número é par ou ímpar usando o operador módulo (%)
// O operador % retorna o resto da divisão do número por 2
// Se o resto for 0, o número é par, caso contrário, é ímpar
if (numero % 2 == 0)
{
    // Se o resto for igual a zero, o número é par
    Console.WriteLine("Número par");
}
else
{
    // Se o resto for diferente de zero, o número é ímpar
    Console.WriteLine("Número ímpar");
}