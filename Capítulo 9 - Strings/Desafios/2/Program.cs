/*
2 - Escreva um programa que solicite ao usuário que digite uma palavra e, 
em seguida, exiba cada caractere separadamente em uma nova linha.
*/

/**************************Solução abaixo*********************************/

Console.WriteLine("Digite uma palavra:");
string palavra = Console.ReadLine(); // Lê a palavra digitada pelo usuário.

// Exibe cada caractere da palavra em uma nova linha.
foreach (char caractere in palavra)
{
    Console.WriteLine(caractere);
}