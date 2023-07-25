int idade = 20;
bool possuiCarteiraMotorista = true;
if (idade >= 18)
{
    if (possuiCarteiraMotorista)
    {
        Console.WriteLine("Você é maior de idade e possui carteira de motorista.");
    }
    else
    {
        Console.WriteLine("Você é maior de idade, mas não possui carteira de motorista.");
    }
}
else
{
    Console.WriteLine("Você é menor de idade.");
}
