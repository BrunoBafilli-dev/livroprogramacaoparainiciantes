Console.Write("Digite a quantidade de números no vetor: "); // Solicita ao usuário a quantidade de números que deseja inserir no vetor.
int tamanho = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na variável 'tamanho'.

int[] vetor = new int[tamanho]; // Cria o vetor com o tamanho informado pelo usuário.

// Preenche o vetor com os números informados pelo usuário
for (int i = 0; i < tamanho; i++) // Loop para percorrer cada posição do vetor e obter os valores do usuário.
{
    Console.Write($"Digite o {i+1}º número: "); // Exibe a mensagem solicitando o valor da posição atual do vetor.
    vetor[i] = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na posição i do vetor.
}

int menorValor = vetor[0]; // Inicializa a variável 'menorValor' com o primeiro elemento do vetor.
int maiorValor = vetor[0]; // Inicializa a variável 'maiorValor' com o primeiro elemento do vetor.

// Percorre o vetor para encontrar o menor e o maior valor
for (int i = 1; i < tamanho; i++) // Loop para percorrer cada posição do vetor a partir da segunda posição.
{
    if (vetor[i] < menorValor) // Verifica se o valor na posição i do vetor é menor do que o valor atual da variável 'menorValor'.
    {
        menorValor = vetor[i]; // Se for menor, atualiza a variável 'menorValor' com o valor da posição i do vetor.
    }

    if (vetor[i] > maiorValor) // Verifica se o valor na posição i do vetor é maior do que o valor atual da variável 'maiorValor'.
    {
        maiorValor = vetor[i]; // Se for maior, atualiza a variável 'maiorValor' com o valor da posição i do vetor.
    }
}

// Exibe os resultados
Console.WriteLine($"Menor valor: {menorValor}"); // Exibe o menor valor presente no vetor.
Console.WriteLine($"Maior valor: {maiorValor}"); // Exibe o maior valor presente no vetor.