/*
1 - Escreva um programa que solicite ao usuário que digite seu nome e, 
em seguida, imprima uma mensagem de boas-vindas usando a string digitada.
*/

/**************************Solução abaixo*********************************/

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine(); // Lê o nome digitado pelo usuário.

// Imprime uma mensagem de boas-vindas usando o nome digitado.
Console.WriteLine($"Olá, {nome}! Bem-vindo(a) ao nosso programa!");