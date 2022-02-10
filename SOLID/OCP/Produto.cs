using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Produto
    {
        // Propriedades encapsuladas
        public int ProdutoID { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        // Campos ou atributos 
        private decimal _custo = 0;

        public decimal Custo
        {
            get => _custo;
            private set
            {
                if (value > 0) _custo = value;
            }
        }

        private decimal _venda = 1;

        public decimal Venda
        {
            get => _venda;
            private set
            {
                if (value > 0) _venda = value;
            }
        }

        public int Estoque { get; private set; }
        public bool Ativo { get; private set; }

        public Produto(int id, string nome, string descricao,
            decimal custo, decimal venda, int estoque, bool ativo)
        {
            ProdutoID = id;
            Nome = nome;
            Descricao = descricao;
            Custo = custo;
            Venda = venda;
            Estoque = estoque;
            Ativo = ativo;
        }

        // Violando o OCP, pois estou modificando a classe para incluir uma funcionalidade
        public double MargemLucro()
        {
            try
            {
                var lucroLiquido = Venda - Custo;
                var margemLucro = (lucroLiquido / Venda) * 100;
                return Convert.ToDouble(margemLucro);
            }
            catch
            {
                throw new InvalidOperationException("Erro ao calcular a margem de lucro.");
            }
        }

    }
}
