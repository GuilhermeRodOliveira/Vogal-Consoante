using System;

namespace EXERCICIOS_ESTRUTURA_CONDICIONAIS_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 - Faça um programa que peça ao usuário para digitar um caractere e, em seguida, verifique se é uma vogal ou uma consoante.
            Console.WriteLine("Insira um letra e informaremos se é vogal ou consoante");
            string letra = Console.ReadLine();

            char caractere = char.ToUpper(letra[0]);
            switch (caractere)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("A letra é uma vogal.");
                    break;

                case 'B':
                case 'C':
                case 'D':
                case 'F':
                case 'G':
                case 'H':
                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                case 'T':
                case 'V':
                case 'W':
                case 'Y':
                case 'Z':
                    Console.WriteLine("A letra é uma consoante.");
                    break;
                
                default: Console.WriteLine("Caractere inválido.");
                    break;

            }
        }
    }
}
