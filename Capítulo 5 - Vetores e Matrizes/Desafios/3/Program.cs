//3 - Crie um programa que copie os elementos de um vetor original para um novo vetor e exiba o novo vetor como saída.

/**************************Solução abaixo*********************************/

Console.Write("Digite a quantidade de elementos do vetor: "); // Solicita ao usuário a quantidade de elementos do vetor.
int tamanhoVetor = Convert.ToInt32(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na variável 'tamanhoVetor'.

int[] vetorOriginal = new int[tamanhoVetor]; // Cria um vetor 'vetorOriginal' com o tamanho informado pelo usuário.

// Preenche o vetorOriginal com os elementos informados pelo usuário.
for (int i = 0; i < tamanhoVetor; i++) // Loop para percorrer cada posição do vetorOriginal.
{
    Console.Write($"Digite o {i+1}º elemento: "); // Exibe a mensagem solicitando o valor da posição atual do vetorOriginal.
    vetorOriginal[i] = Convert.ToInt32(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na posição i do vetorOriginal.
}

int[] novoVetor = new int[tamanhoVetor]; // Cria um novo vetor 'novoVetor' com o mesmo tamanho do vetorOriginal.

// Copia os elementos do vetorOriginal para o novoVetor.
for (int i = 0; i < tamanhoVetor; i++) // Loop para percorrer cada posição do vetorOriginal.
{
    novoVetor[i] = vetorOriginal[i]; // Copia o elemento da posição i do vetorOriginal para a posição i do novoVetor.
}

// Exibe o novoVetor como saída.
Console.WriteLine("Novo vetor copiado do vetor original:");
for (int i = 0; i < tamanhoVetor; i++) // Loop para percorrer cada posição do novoVetor.
{
    Console.Write(novoVetor[i] + " "); // Exibe o elemento da posição i do novoVetor.
}

Console.WriteLine(); // Pula uma linha após exibir o novoVetor.