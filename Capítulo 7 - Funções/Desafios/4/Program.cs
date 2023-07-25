/*
4 - Crie uma função chamada "saudacaoPersonalizada" que recebe dois parâmetros: nome e mensagem. 
O parâmetro mensagem tem um valor padrão "Bem-vindo(a)!" caso não seja fornecido um argumento. 
A função deve imprimir a mensagem de saudação para o nome especificado. 
Em seguida, chame a função passando apenas o nome e depois passando o nome e uma mensagem personalizada.
*/

/**************************Solução abaixo*********************************/

string nome = "João";

// Chamando a função com apenas o nome.
SaudacaoPersonalizada(nome);

// Chamando a função com o nome e uma mensagem personalizada.
SaudacaoPersonalizada(nome, "Olá");

static void SaudacaoPersonalizada(string nome, string mensagem = "Bem-vindo(a)!")
{
    Console.WriteLine($"{mensagem} {nome}!"); // Imprime a saudação personalizada.
}