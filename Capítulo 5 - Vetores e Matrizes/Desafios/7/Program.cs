 // Solicitar ao usuário o tamanho do vetor
Console.Write("Digite o tamanho do vetor: ");
int tamanho = Convert.ToInt32(Console.ReadLine());

// Criar o vetor com o tamanho informado pelo usuário
int[] vetor = new int[tamanho];

// Preencher o vetor com os valores informados pelo usuário
for (int i = 0; i < tamanho; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
}

// Ordenar o vetor em ordem crescente
Array.Sort(vetor);

// Solicitar ao usuário o número específico a ser procurado
Console.Write("Digite o número a ser procurado: ");
int numeroProcurado = Convert.ToInt32(Console.ReadLine());

// Executar a busca binária
int inicio = 0;
int fim = tamanho - 1;
bool encontrado = false;

while (inicio <= fim)
{
    int meio = inicio + (fim - inicio) / 2;

    if (vetor[meio] == numeroProcurado)
    {
        encontrado = true;
        break;
    }
    else if (vetor[meio] < numeroProcurado)
    {
        inicio = meio + 1;
    }
    else
    {
        fim = meio - 1;
    }
}

// Exibir o resultado da busca
if (encontrado)
    Console.WriteLine($"O número {numeroProcurado} foi encontrado no vetor.");
else
    Console.WriteLine($"O número {numeroProcurado} não foi encontrado no vetor.");