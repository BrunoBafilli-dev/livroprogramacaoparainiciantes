/*
1 - Exibir os números pares de 1 a 20 utilizando um loop for
*/

/**************************Solução abaixo*********************************/

Console.WriteLine("Números pares de 1 a 20:");

// Loop for para percorrer os números de 1 a 20
for (int i = 1; i <= 20; i++)
{
    // Verifica se o número é par
    if (i % 2 == 0)
    {
        // Se for par, exibe o número
        Console.Write(i + " ");
    }
}

Console.WriteLine(); // Quebra de linha após a exibição dos números pares