// 2 - Escreva um programa que solicite um número ao usuário. Em seguida, o programa deve verificar se o 
// número é positivo, negativo ou zero, exibindo a mensagem correspondente.

/**************************Solução abaixo*********************************/

// Solicitar ao usuário que insira um número
Console.Write("Digite um número: ");

// Ler o número digitado pelo usuário e armazená-lo em uma variável
double numero = double.Parse(Console.ReadLine());

// Verificar se o número é positivo, negativo ou zero
if (numero > 0)
{
    Console.WriteLine("O número é positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("O número é negativo.");
}
else
{
    Console.WriteLine("O número é zero.");
}