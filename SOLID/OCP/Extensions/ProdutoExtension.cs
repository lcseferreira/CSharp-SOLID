using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Extensions
{
    // Utilizando uma classe static para criar meus métodos de extensão para Produto
    public static class ProdutoExtension
    {
        // Criando um método de extensão para não modificar a classe Produto
        public static double MargemLucroOCP(this Produto produto)
        {
            try
            {
                var lucroLiquido = produto.Venda - produto.Custo;
                var margemLucro = (lucroLiquido / produto.Venda) * 100;

                return Convert.ToDouble(margemLucro);
            }
            catch
            {
                throw new InvalidOperationException("Erro ao calcular a margem de lucro.");
            }
        }
    }
}
