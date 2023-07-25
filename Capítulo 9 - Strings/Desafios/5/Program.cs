/*
Escreva um programa que solicite ao usuário que digite uma frase. Em seguida, realize as seguintes operações:
•	Imprima o número total de caracteres na frase.

•	Converta a frase para letras maiúsculas e imprima-a.

•	Verifique se a frase contém a palavra "exemplo" e imprima o resultado.

*/

/**************************Solução abaixo*********************************/

Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine(); // Lê a frase digitada pelo usuário.

// Imprime o número total de caracteres na frase.
Console.WriteLine($"Número total de caracteres na frase: {frase.Length}");

// Converte a frase para letras maiúsculas e imprime-a.
string fraseMaiusculas = frase.ToUpper();
Console.WriteLine($"Frase em letras maiúsculas: {fraseMaiusculas}");

// Verifica se a frase contém a palavra "exemplo" e imprime o resultado.
bool contemExemplo = fraseMaiusculas.Contains("EXEMPLO");
Console.WriteLine($"A frase {(contemExemplo ? "contém" : "não contém")} a palavra (exemplo).");