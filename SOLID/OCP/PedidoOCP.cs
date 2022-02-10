using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class PedidoOCP
    {
        public virtual double DescontaPedido(double valorFinal)
        {
            return valorFinal;
        }


        // Esse método quebra o OCP porque se precisarmos adicionar outro tipo de cliente, precisaremos mexer no código 
        //public double DescontoPedido(double valor, TipoCliente tipoCliente)
        //{
        //    double valorFinal;

        //    if (tipoCliente == TipoCliente.Especial)
        //    {
        //        valorFinal = valor - 50;
        //    }
        //    else if (tipoCliente == TipoCliente.Associado)
        //    {
        //        valorFinal = valor - 10;
        //    }
        //    else
        //    {
        //        valorFinal = valor;
        //    }

        //    return valorFinal;
        //}
    }
}
