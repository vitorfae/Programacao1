﻿using System;

class Program 
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Suas opções:");
            Console.WriteLine("1 - Primeira Opção Cálculo Aritmético");
            Console.WriteLine("2 - Segunda Opção Sair");
            Console.Write("Informe um número da opção acima: ");
            string leitura = Console.ReadLine();
            int.TryParse(leitura, out int opcao);

            if (opcao == 1)
            {
                Console.WriteLine("Cálculo aritmético");
                Console.WriteLine();
                Console.WriteLine("Informe um número: ");
                string numero1 = Console.ReadLine();
                int.TryParse(numero1, out int n1);

                Console.WriteLine("Informe outro número: ");
                string numero2 = Console.ReadLine();
                int.TryParse(numero2, out int n2);

                var soma = n1 + n2;
                var subtracao = n1 - n2;
                var multiplicacao = n1 * n2;

                
                float divisao = 0;
                if (n2 != 0)
                    divisao = (float)n1 / n2;

                var resto = n1 % n2;
                
                var potencia = Math.Pow(n1, n2);

                Console.WriteLine();
                Console.WriteLine($"A soma entre {n1} e {n2} é igual a {soma}");
                Console.WriteLine($"A subtração entre {n1} e {n2} é igual a {subtracao}");
                Console.WriteLine($"A multiplicação entre {n1} e {n2} é igual a {multiplicacao}");
                Console.WriteLine($"A divisão entre {n1} e {n2} é igual a {divisao}");
                Console.WriteLine($"O resto da divisão entre {n1} e {n2} é igual a {resto}");
                Console.WriteLine($"A potência entre {n1} e {n2} é igual a {potencia}");

                Console.WriteLine();
                Console.WriteLine("Programa finalizado");
                break;
            }
            else if (opcao == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção errada");
                continue;
            }
        }
    }
}
