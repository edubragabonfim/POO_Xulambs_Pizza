using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_N_Xulambs_Pizza
{
    class Pizza
    {
        int _totalIngredientes;
        int _maximoIngredientes;
        string _descricao;
        double _precoBase;
        double _precoAdicional;

        public Pizza()
        {
            _totalIngredientes = 0;
            _maximoIngredientes = 8;
            _descricao = "Pizza";
            _precoBase = 29d;
            _precoAdicional = 5d;
        }

        /// <summary>
        /// Método usado internamento dentro da classe para verificar se a quantidade de ingredientes que serão adicionados é permitido, dados o máximo de ingrdientes possíveiss.
        /// </summary>
        /// <param name="quantos">Quantidade de ingredientes a serem adicionados na pizza.</param>
        /// <returns></returns>
        private bool VerificarLimite(int quantos)
        {
            return (quantos > 0 && quantos + _totalIngredientes <= _maximoIngredientes);
        }

        /// <summary>
        /// Adiciona ingredientes na pizza.
        /// </summary>
        /// <param name="quantos">Quantidade de ingredientes a serem adicionados na pizza.</param>
        /// <returns></returns>
        public int AdicionarIngrediente(int quantos)
        {
            if (VerificarLimite(quantos))
            {
                _totalIngredientes += quantos;
            }
            return _totalIngredientes;
        }

        /// <summary>
        /// Retorna as informações gerais da Pizza. Como descrição, Valor de Venda e Total de ingredientes.
        /// </summary>
        /// <returns>Retorna uma string com a Nota de compra.</returns>
        public string EmitirCupom()
        {
            return $"{_descricao} | Valor: {ValorVenda()} | Com {_totalIngredientes} adicionais.";
        }

        /// <summary>
        /// Cálcula o valor total dos adicionais.
        /// </summary>
        /// <returns>Retorna um número referente ao valor total dos adicionais.</returns>
        private double ValorAdicional()
        {
            return _totalIngredientes * _precoAdicional;
        }

        /// <summary>
        /// Calcula o valor total da Pizza, sendo: Preço base + Adicionais.
        /// </summary>
        /// <returns>Retorna o valor total da pizza.</returns>
        public double ValorVenda()
        {
            return _precoBase + ValorAdicional();
        }

    }
}
