//3 - Elabore um programa que peça ao usuário para digitar sua nota em uma prova. 
//Com base na nota fornecida, exiba a seguinte classificação:
    //• Se a nota for maior ou igual a 7, exiba "Aprovado".
    //• Se a nota for maior ou igual a 5 e menor que 7, exiba "Recuperação".
    //• Caso contrário, exiba "Reprovado".

/**************************Solução abaixo*********************************/

// Solicitar ao usuário que insira a nota da prova
Console.Write("Digite sua nota na prova: ");

// Ler a nota digitada pelo usuário e armazená-la em uma variável
double nota = double.Parse(Console.ReadLine());

// Verificar a classificação da nota
if (nota >= 7)
{
    // Se a nota for maior ou igual a 7, o aluno está "Aprovado"
    Console.WriteLine("Aprovado");
}
else if (nota >= 5 && nota < 7)
{
    // Se a nota for maior ou igual a 5 e menor que 7, o aluno está em "Recuperação"
    Console.WriteLine("Recuperação");
}
else
{
    // Caso contrário, a nota é menor que 5 e o aluno está "Reprovado"
    Console.WriteLine("Reprovado");
}