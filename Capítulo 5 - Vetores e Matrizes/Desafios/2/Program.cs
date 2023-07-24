Console.Write("Digite o tamanho da matriz quadrada (número de linhas e colunas): ");
int tamanhoMatriz = int.Parse(Console.ReadLine());

int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz]; // Cria uma matriz quadrada com o tamanho informado.

// Preenche a matriz com os elementos informados pelo usuário.
for (int i = 0; i < tamanhoMatriz; i++) // Loop para percorrer as linhas da matriz.
{
    for (int j = 0; j < tamanhoMatriz; j++) // Loop para percorrer as colunas da matriz.
    {
        Console.Write($"Digite o elemento da posição [{i}, {j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

bool ehMatrizDiagonal = true; // Variável para armazenar se a matriz é diagonal, assume-se verdadeiro inicialmente.

// Verifica se a matriz é diagonal (todos os elementos fora da diagonal principal são iguais a zero).
for (int i = 0; i < tamanhoMatriz; i++) // Loop para percorrer as linhas da matriz.
{
    for (int j = 0; j < tamanhoMatriz; j++) // Loop para percorrer as colunas da matriz.
    {
        // Se a posição não pertence à diagonal principal e o elemento não é zero, a matriz não é diagonal.
        if (i != j && matriz[i, j] != 0)
        {
            ehMatrizDiagonal = false;
            break; // Pode encerrar o loop, pois já sabemos que a matriz não é diagonal.
        }
    }

    if (!ehMatrizDiagonal) // Se já foi identificado que a matriz não é diagonal, encerra o loop externo.
    {
        break;
    }
}

// Exibe o resultado se a matriz é diagonal ou não.
if (ehMatrizDiagonal)
{
    Console.WriteLine("A matriz inserida é uma matriz diagonal.");
}
else
{
    Console.WriteLine("A matriz inserida não é uma matriz diagonal.");
}
            