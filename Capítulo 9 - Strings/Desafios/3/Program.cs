/*
3 - Escreva um programa que declare uma variável string contendo um texto e, em seguida, 
tente modificar um caractere específico da string. 
Observe como ocorre um erro de compilação devido à imutabilidade das strings.
*/

/**************************Solução abaixo*********************************/
string texto = "Hello, world!"; // Declara uma variável string contendo um texto.

// Tenta modificar um caractere específico da string.
// Isso causará um erro de compilação, pois strings são imutáveis.
texto[0] = 'h'; // Erro de compilação: "System.String' does not contain a definition for 'string.this[int]'"