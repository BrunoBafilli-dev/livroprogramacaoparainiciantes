Console.WriteLine("Digite números positivos. Digite um número negativo para encerrar."); // Exibe a mensagem para o usuário no console.

            int numero; // Declara a variável inteira 'numero' para armazenar os números digitados pelo usuário.
            bool numeroNegativoDigitado = false; // Declara a variável booleana 'numeroNegativoDigitado' para controlar o loop while.

            // Loop while para continuar solicitando números até que um número negativo seja digitado.
            while (!numeroNegativoDigitado) // Enquanto 'numeroNegativoDigitado' for false (ou seja, não foi digitado um número negativo ainda).
            {
                Console.Write("Digite um número: "); // Exibe a mensagem para o usuário no console, solicitando que digite um número.
                numero = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e converte o valor para um inteiro, armazenando na variável 'numero'.

                if (numero < 0) // Verifica se o número digitado é negativo.
                {
                    numeroNegativoDigitado = true; // Se o número for negativo, atribui true à variável 'numeroNegativoDigitado' para encerrar o loop.
                }
            }

            Console.WriteLine("Número negativo digitado. Encerrando o programa."); // Exibe a mensagem de encerramento para o usuário no console.