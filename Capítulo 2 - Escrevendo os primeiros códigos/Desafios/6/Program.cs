 // Solicitar ao usuário que insira um número inteiro
Console.Write("Digite um número inteiro: ");

// Ler o número digitado pelo usuário e armazená-lo em uma variável
int numero = int.Parse(Console.ReadLine());

// Exibir a tabuada do número digitado
Console.WriteLine($"Tabuada do {numero}:");

// Utilizando o loop for para iterar de 1 a 10
for (int i = 1; i <= 10; i++)
{
    // Calcular o resultado da multiplicação entre o número digitado e o multiplicador (i)
    int resultado = numero * i;

    // Exibir cada linha da tabuada mostrando o número, o multiplicador e o resultado da multiplicação
    Console.WriteLine($"{numero} x {i} = {resultado}");
}