using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio5
{
    internal class GerDesc
    {
        public decimal Calcular(decimal valor, int tipo, int anos)
        {
            decimal resultado = 0;
            decimal desc = (anos > 5) ? (decimal)5 / 100 : (decimal)anos / 100;

            if (tipo == 1)
            {
                resultado = valor;
            }
            else if (tipo == 2)
            {
                resultado = (valor - (0.1M * valor)) - desc * (valor - (0.1M * valor));
            }
            else if (tipo == 3)
            {
                resultado = (0.7M * valor) - desc * (0.7M * valor);
            }
            else if (tipo == 4)
            {
                resultado = (valor - (0.5M * valor)) - desc * (valor - (0.5M * valor));
            }

            return resultado;
        }
    }
}
