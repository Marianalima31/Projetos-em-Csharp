﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair) //Enquanto o úsuario Não (!) Escolheu essa exiba o Menu 
            {
                Console.WriteLine("Seja Bem vindo ao Math, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)

                {
                    
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Multi();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();

            }
        }
        
        static void Soma()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($" O resultado é {resultado}");
            Console.WriteLine("Aperte enter para retornar ao menu");
            Console.ReadLine();

        }

        static void Sub()
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($" O resultado é {resultado}");
            Console.WriteLine("Aperte enter para retornar ao menu");
            Console.ReadLine();

        }

        static void Div()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            double resultado = (double)a/(double)b;
            Console.WriteLine($" O resultado é {resultado}");
            Console.WriteLine("Aperte enter para retornar ao menu");
            Console.ReadLine();

        }

        static void Multi()
        {
            Console.WriteLine("Multiplicação de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($" O resultado é {resultado}");
            Console.WriteLine("Aperte enter para retornar ao menu");
            Console.ReadLine();

        }

        static void Pot()
        {
            Console.WriteLine("Potência de um número");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($" O resultado é {resultado}");
            Console.WriteLine("Aperte enter para retornar ao menu");
            Console.ReadLine();

        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um número");
            Console.WriteLine("Digite o número: ");
            double a  = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($" O resultado é {resultado}");
            Console.WriteLine("Aperte enter para retornar ao menu");
            Console.ReadLine();

        }
    }
}
