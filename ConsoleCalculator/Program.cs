using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator {
    internal class Program {
        static void Main(string[] args) {
            int operacao;
            float num1 = 0;
            float num2 = 0;
            float resultado = 0;

            Console.WriteLine("Qual operação deseja fazer?\n 1-Adição\n 2-Subtração\n 3-Divisão\n 4-Multiplicação");

            operacao = int.Parse(Console.ReadLine());

            if (operacao == 1 || operacao == 2 || operacao == 3 || operacao == 4) {
                Console.WriteLine("Digite o primeiro número: ");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                num2 = float.Parse(Console.ReadLine());
            }

            switch (operacao) {
                case 1: resultado = somar(num1, num2);
                break;
                case 2:
                resultado = subtrair(num1, num2);
                break;
                case 3:
                resultado = dividir(num1, num2);
                break;
                case 4:
                resultado = multiplicar(num1, num2);
                break;
                default: Console.WriteLine("Digite um valor operacional válido");
                break;
            }
            if (operacao == 1 || operacao == 2 || operacao == 3 || operacao == 4) {
                Console.WriteLine($"O valor da operação é: {resultado}");
            }
           
            Console.ReadLine();
        }

        public static float somar(float a, float b) {
            return a + b;
        }
        public static float subtrair(float a, float b) {
            return a - b;
        }
        public static float dividir(float a, float b) {
            return a / b;
        }
        public static float multiplicar(float a, float b) {
            return a * b;
        }
    }

}


