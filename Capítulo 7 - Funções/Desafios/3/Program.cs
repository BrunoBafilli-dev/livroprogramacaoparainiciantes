//3 - Crie uma função chamada "incrementar" que recebe um parâmetro inteiro por referência e incrementa seu valor em 1. 
//Em seguida, chame a função passando uma variável inteira como argumento e imprima o valor antes e depois da chamada da função.

/**************************Solução abaixo*********************************/

int valor = 5; // Declara uma variável inteira "valor" e atribui o valor 5.

Console.WriteLine("Valor antes da chamada da função: " + valor);

Incrementar(ref valor); // Chamando a função "Incrementar" e passando a variável "valor" por referência.

Console.WriteLine("Valor depois da chamada da função: " + valor);

void Incrementar(ref int numero)
{
    numero++; // Incrementa o valor do parâmetro inteiro em 1.
}