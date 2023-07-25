/*
5 - Crie um programa que redimensione um vetor de números inteiros. Peça ao usuário para inserir 
o tamanho original do vetor e os valores dos elementos. Em seguida, reduza o tamanho do vetor 
para a metade e exiba o novo vetor resultante.
*/

/**************************Solução abaixo*********************************/

// Solicitar ao usuário o tamanho original do vetor
Console.Write("Digite o tamanho original do vetor: ");
int tamanhoOriginal = Convert.ToInt32(Console.ReadLine());

// Criar o vetor com o tamanho informado pelo usuário
int[] vetorOriginal = new int[tamanhoOriginal];

// Preencher o vetor com os valores informados pelo usuário
for (int i = 0; i < tamanhoOriginal; i++)
{
    Console.Write($"Digite o valor para o elemento {i + 1}: ");
    vetorOriginal[i] = Convert.ToInt32(Console.ReadLine());
}

// Reduzir o tamanho do vetor para a metade
int novoTamanho = tamanhoOriginal / 2;
int[] novoVetor = new int[novoTamanho];

// Copiar os elementos para o novo vetor
for (int i = 0; i < novoTamanho; i++)
{
    novoVetor[i] = vetorOriginal[i];
}

// Exibir o novo vetor resultante
Console.WriteLine("\nNovo vetor resultante:");
for (int i = 0; i < novoTamanho; i++)
{
    Console.WriteLine($"Elemento {i + 1}: {novoVetor[i]}");
}