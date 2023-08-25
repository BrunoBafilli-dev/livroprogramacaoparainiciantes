/*
2 - Crie um programa que solicite ao usuário dois números e, em seguida, exiba a soma desses dois números.
*/

/**************************Solução abaixo*********************************/

Console.Write("Digite o primeiro número: ");  // Exibe uma mensagem pedindo ao usuário para digitar o primeiro número.
int numero1 = int.Parse(Console.ReadLine());  // Lê o número digitado pelo usuário e converte para um valor inteiro, armazenando em "numero1".

Console.Write("Digite o segundo número: ");  // Exibe uma mensagem pedindo ao usuário para digitar o segundo número.
int numero2 = int.Parse(Console.ReadLine());  // Lê o número digitado pelo usuário e converte para um valor inteiro, armazenando em "numero2".

int soma = numero1 + numero2;  // Calcula a soma dos dois números e armazena o resultado em "soma".

Console.WriteLine($"A soma de {numero1} e {numero2} é: {soma}");  // Exibe o resultado da soma na tela.