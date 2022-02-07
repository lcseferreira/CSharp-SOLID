using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POO
{
    public static class SobrecargaMetodos
    {
        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        // Sobrecarga de método
        public static double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        // Sobrecarga de método aceitando infinitos parâmetros (params)
        public static int Somar(params int[] numeros)
        {
            int soma = 0;

            foreach (int numero in numeros)
            {
                soma += numero;
            }

            return soma;
        }

        // Sobrecarga de método com parâmetros opcionais
        public static int SomarOpcional(int numero1, int numero2, int opcional = 10)
        {
            return numero1 + numero2 + opcional;
        }

    }
}
