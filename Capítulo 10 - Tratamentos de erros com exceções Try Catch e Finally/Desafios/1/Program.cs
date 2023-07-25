/*
1 - Se o usuário digitar um valor não numérico, exiba a mensagem "Entrada inválida! Digite apenas números inteiros."
*/

/**************************Solução abaixo*********************************/
// Solicita ao usuário que digite um número inteiro
Console.WriteLine("Digite um número inteiro:");

// Lê a entrada do usuário como uma string e armazena na variável "input"
string input = Console.ReadLine();

try
{
    // Tentativa de converter a entrada para um número inteiro usando Convert.ToInt32()
    int number = Convert.ToInt32(input);

    // Se a conversão for bem-sucedida, imprime o número digitado pelo usuário
    Console.WriteLine("Número digitado: " + number);
}
catch (FormatException)
{
    // Se ocorrer uma exceção do tipo FormatException (ocorre quando a conversão falha),
    // exibe a mensagem de erro informando que apenas números inteiros são permitidos.
    Console.WriteLine("Entrada inválida! Digite apenas números inteiros.");
}