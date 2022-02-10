using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.POO
{
    public class ModeloRico
    {
        // Propriedades
        public int ItemId { get; private set; }
        public int PedidoId { get; private set; }

        // Atributos
        private string _itemNome;
        private decimal _itemPreco;

        public string ItemNome
        {
            get => _itemNome;

            // Validação do setter com operador ternário
            set
            {
                _itemNome = (value.Length > 100) ?
                    throw new ArgumentOutOfRangeException(nameof(ItemNome),
                    "O nome do item não pode exceder 100 caracteres.") : value;
            }
        }

        public decimal ItemPreco
        {
            get => _itemPreco;

            // Validação do setter com lambda e operador ternário 
            set => _itemPreco = (value <= 0) ?
                throw new ArgumentOutOfRangeException(nameof(ItemPreco),
                    "O valor precisa ser maior que 0.") : value;
        }

        // Construtor
        public ModeloRico(int itemId, int pedidoId, string itemNome, decimal itemPreco)
        {
            // Validações
            if (itemId <= 0) throw new ArgumentException("O código do item deve ser informado com o valor maior que 0.");
            if (pedidoId <= 0) throw new ArgumentException("O código do peido deve ser informado com o valor maior que 0.");

            ItemId = itemId;
            PedidoId = pedidoId;
            ItemNome = itemNome;
            ItemPreco = itemPreco;
        }
    }
}

