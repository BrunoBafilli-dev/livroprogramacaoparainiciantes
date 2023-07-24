Console.Write("Digite um número inteiro positivo: "); // Exibe a mensagem no console, solicitando que o usuário digite um número inteiro positivo.
int numero = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na variável 'numero'.

int numDivisores = 0; // Declara e inicializa a variável 'numDivisores' com zero para contar quantos divisores o número digitado possui.

// Loop for para verificar os divisores do número digitado.
// O loop inicia com i = 1 e vai até i <= numero, verificando os números de 1 até o número digitado.
for (int i = 1; i <= numero; i++)
{
    // Verifica se o número digitado é divisível por i (ou seja, se o resto da divisão é zero).
    if (numero % i == 0)
    {
        numDivisores++; // Se o resto da divisão for zero, incrementa a variável 'numDivisores' para contar os divisores.
    }
}

// Verifica se o número digitado é primo, ou seja, se possui apenas dois divisores: ele mesmo e o número 1.
// Se a variável 'numDivisores' for igual a 2, significa que o número é primo.
if (numDivisores == 2)
{
    // Exibe a mensagem informando que o número digitado é primo.
    Console.WriteLine(numero + " é um número primo.");
}
else
{
    // Caso contrário, exibe a mensagem informando que o número digitado não é primo.
    Console.WriteLine(numero + " não é um número primo.");
}