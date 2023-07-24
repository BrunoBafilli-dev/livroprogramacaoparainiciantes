int numero; // Declara a variável inteira 'numero' para armazenar os números digitados pelo usuário.
int soma = 0; // Inicializa a variável 'soma' com zero para acumular a soma dos números digitados (exceto o zero).
int quantidadeNumeros = 0; // Inicializa a variável 'quantidadeNumeros' com zero para contar a quantidade de números digitados (exceto o zero).

Console.WriteLine("Digite uma sequência de números. Digite 0 para encerrar e calcular a média."); // Exibe a mensagem para o usuário no console.

// Loop do-while para continuar solicitando números até que o número zero seja digitado.
do // O loop executa pelo menos uma vez, mesmo que a condição de parada não seja atendida, pois a verificação é feita no final do loop.
{
    Console.Write("Digite um número: "); // Exibe a mensagem para o usuário no console, solicitando que digite um número.
    numero = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na variável 'numero'.

    // Se o número digitado for diferente de zero, atualiza a soma e a quantidade de números.
    if (numero != 0)
    {
        soma += numero; // Atualiza a variável 'soma' somando o valor digitado.
        quantidadeNumeros++; // Incrementa a variável 'quantidadeNumeros' para contar a quantidade de números digitados.
    }

} while (numero != 0); // O loop continua enquanto o número digitado for diferente de zero.

// Calcula a média dos números digitados (exceto o zero, que é o critério de parada).
double media = (double)soma / quantidadeNumeros; // Converte a variável 'soma' para o tipo double para garantir que a média seja calculada como um número decimal.

Console.WriteLine("Média dos números digitados: " + media); // Exibe a mensagem com a média dos números digitados para o usuário no console.