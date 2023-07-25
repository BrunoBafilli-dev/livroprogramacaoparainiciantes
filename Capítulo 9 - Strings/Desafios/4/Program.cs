/*
4 - Escreva um programa que solicite ao usuário que digite duas palavras e, 
em seguida, compare as strings para verificar se são iguais. 
Imprima uma mensagem informando se as palavras são iguais ou diferentes.
*/

/**************************Solução abaixo*********************************/
Console.WriteLine("Digite a primeira palavra:");
string palavra1 = Console.ReadLine(); // Lê a primeira palavra digitada pelo usuário.

Console.WriteLine("Digite a segunda palavra:");
string palavra2 = Console.ReadLine(); // Lê a segunda palavra digitada pelo usuário.

// Compara as strings usando o método Equals() para verificar se são iguais.
bool saoIguais = palavra1.Equals(palavra2, StringComparison.OrdinalIgnoreCase);

// Imprime a mensagem informando se as palavras são iguais ou diferentes.
if (saoIguais)
{
    Console.WriteLine("As palavras são iguais.");
}
else
{
    Console.WriteLine("As palavras são diferentes.");
}