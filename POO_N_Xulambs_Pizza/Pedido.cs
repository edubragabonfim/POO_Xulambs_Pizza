using POO_N_Xulambs_Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods_2025_1.src
{
    public class Pedido
    {
        private static int s_ultimoPedido = 0;

        private int _idPedido;
        private DateOnly _data;
        private LinkedList<Pizza> _pizzas;
        private bool _aberto;


        #region Métodos

        /// <summary>
        /// Método construtor da Classe.
        /// </summary>
        public Pedido()
        {
            _idPedido = ++s_ultimoPedido;
            _data = DateOnly.FromDateTime(DateTime.Now);
            _pizzas = new LinkedList<Pizza>();
            _aberto = true;

        }

        /// <summary>
        /// Método usado para verificar se é possível adicionar Pizzas ao pedido, dado que ele pode estar aberto ou fechado.
        /// </summary>
        /// <returns>Retorna true se ainda for possível adicionar Pizzas ao pedido.</returns>
        private bool PodeAdicionar()
        {
            //bool result = false;
            //if (_aberto)
            //    result = true;
            //return result;
            return _aberto;
        }

        /// <summary>
        /// Método usado para adicionar uma pizza ao pedido.
        /// </summary>
        /// <param name="pizza">Um objeto Pizza.</param>
        /// <returns>Retorna a quantidade de pizzas inclusas no pedido.</returns>
        public int Adicionar(Pizza pizza)
        {
            if (PodeAdicionar())
                _pizzas.AddLast(pizza);
            return _pizzas.Count;
        }

        /// <summary>
        /// Método chamado para fechar o pedido;
        /// </summary>
        public void FecharPedido()
        {
            _aberto = false;

        }

        /// <summary>
        /// Calcula o Valor total do Pedido.
        /// </summary>
        /// <returns>Retorna a soma do valor total das Pizzas.</returns>
        public double PrecoAPagar()
        {
            double valorTotal = 0;
            foreach(Pizza p in _pizzas)
            {
                valorTotal += p.ValorVenda();
            }
            return valorTotal;
        }

        /// <summary>
        /// Método que exibe um relatório do Pedido.
        /// </summary>
        /// <returns>String uma descrição do pedido.</returns>
        public string Relatorio()
        {
            //string status = _aberto ? "Aberto" : "Fechado";
            //return $"Pedido {_idPedido} - Quantidade de Pizzas {_pizzas.Count} | Status Pedido: {status} | Valor total: {PrecoAPagar():C2}";

            StringBuilder relat = new StringBuilder("===============================\n" + "Pedido nº " + _idPedido + " - " + _data + "\n");
            foreach(Pizza p in _pizzas)
            {
                relat.AppendLine(p.EmitirCupom());
            }
            relat.AppendLine($"Total a Pagar: {PrecoAPagar():C2} \n");
            return relat.ToString();
        
        }

        #endregion
    
    }
}