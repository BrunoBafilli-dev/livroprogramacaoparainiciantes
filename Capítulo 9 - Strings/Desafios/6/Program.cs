/*
6 - Escreva um programa que declare um objeto StringBuilder vazio. 
Em seguida, solicite ao usuário que digite uma frase e adicione-a ao objeto StringBuilder. 
Por fim, imprima a frase invertida utilizando o método Reverse do StringBuilder.
*/

/**************************Solução abaixo*********************************/
using System.Text; // Importa o namespace que contém a classe StringBuilder.

 StringBuilder construtorFrase = new StringBuilder(); // Declara um objeto StringBuilder vazio.

Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine(); // Lê a frase digitada pelo usuário.

construtorFrase.Append(frase); // Adiciona a frase ao objeto StringBuilder.

// Inverte a frase usando o método InverterStringBuilder.
StringBuilder construtorFraseInvertido = InverterStringBuilder(construtorFrase);

// Imprime a frase invertida.
Console.WriteLine("Frase invertida: " + construtorFraseInvertido);

 // Método para inverter um StringBuilder.
StringBuilder InverterStringBuilder(StringBuilder sb)
{
    StringBuilder invertido = new StringBuilder();
    for (int i = sb.Length - 1; i >= 0; i--)
    {
        invertido.Append(sb[i]);
    }
    return invertido;
}