/*
4 - Crie um programa que receba uma lista de nomes como entrada e use um 
loop foreach para exibir cada nome em uma linha separada.
*/

/**************************Solução abaixo*********************************/

Console.Write("Digite a quantidade de nomes: "); // Solicita ao usuário a quantidade de nomes a serem digitados.
int quantidadeNomes = Convert.ToInt16(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na variável 'quantidadeNomes'.

string[] nomes = new string[quantidadeNomes]; // Cria um vetor 'nomes' com o tamanho informado pelo usuário.

for (int i = 0; i < quantidadeNomes; i++) // Loop para preencher o vetor com os nomes informados pelo usuário.
{
    Console.Write($"Digite o {i + 1}º nome: "); // Exibe a mensagem solicitando o valor do nome na posição atual do vetor.
    nomes[i] = Console.ReadLine(); // Lê a entrada do usuário e armazena o nome na posição i do vetor 'nomes'.
}

Console.WriteLine("\nNomes digitados:"); // Exibe a mensagem indicando que os nomes digitados serão exibidos abaixo.

foreach (string nome in nomes) // Utiliza um loop foreach para exibir cada nome em uma linha separada.
{
    Console.WriteLine(nome); // Exibe o nome na tela.
}