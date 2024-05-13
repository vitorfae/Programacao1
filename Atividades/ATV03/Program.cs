﻿using System;

class Program
{
    static void Main(string[] args)
    {
        char operador;

        // Pergunta ao usuário pelo operador até que seja um válido (+ - * /)
        do
        {
            Console.WriteLine("Por favor, escolha um operador aritmético (+ - * /):");
            operador = Console.ReadKey().KeyChar;
            Console.WriteLine();
        } while (operador != '+' && operador != '-' && operador != '*' && operador != '/');

        // Imprime a tabuada com base no operador escolhido
        switch (operador)
        {
            case '+':
                ImprimirTabuadaDeAdicao();
                break;
            case '-':
                ImprimirTabuadaDeSubtracao();
                break;
            case '*':
                ImprimirTabuadaDeMultiplicacao();
                break;
            case '/':
                ImprimirTabuadaDeDivisao();
                break;
        }

        Console.ReadLine(); // Espera que o usuário pressione Enter antes de fechar o programa
    }

    static void ImprimirTabuadaDeAdicao()
    {
        Console.WriteLine("Tabuada de Adição:");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine($"{i} + {j} = {i + j}");
            }
            Console.WriteLine();
        }
    }

    static void ImprimirTabuadaDeSubtracao()
    {
        Console.WriteLine("Tabuada de Subtração:");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine($"{i} - {j} = {i - j}");
            }
            Console.WriteLine();
        }
    }

    static void ImprimirTabuadaDeMultiplicacao()
    {
        Console.WriteLine("Tabuada de Multiplicação:");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }

    static void ImprimirTabuadaDeDivisao()
    {
        Console.WriteLine("Tabuada de Divisão:");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                if (j != 0)
                {
                    Console.WriteLine($"{i} / {j} = {i / (double)j}");
                }
            }
            Console.WriteLine();
        }
    }
}