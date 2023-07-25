// 2 - Você está desenvolvendo um programa de agendamento e precisa criar um 
//sistema para representar os diferentes meses do ano. Utilize enumeradores para criar os meses 
//(Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro).

/**************************Solução abaixo*********************************/

// Atribuindo o valor Meses.Julho à variável mesAtual
Meses mesAtual = Meses.Julho;

// Exibindo o mês atual usando Console.WriteLine()
Console.WriteLine("O mês atual é: " + mesAtual);

// Declaração do enum Meses
enum Meses
{
    Janeiro,   // Valor 0
    Fevereiro, // Valor 1
    Março,     // Valor 2
    Abril,     // Valor 3
    Maio,      // Valor 4
    Junho,     // Valor 5
    Julho,     // Valor 6
    Agosto,    // Valor 7
    Setembro,  // Valor 8
    Outubro,   // Valor 9
    Novembro,  // Valor 10
    Dezembro   // Valor 11
}