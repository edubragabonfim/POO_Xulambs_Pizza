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

        public int AdicionarIngrediente(int quantos)
        {
            if (VerificarLimite(quantos))
            {
                _totalIngredientes += quantos;
            }
            return _totalIngredientes;
        }

        public string EmitirCupom()
        {
            return $"{_descricao} | Valor: {ValorVenda()} | Com {_totalIngredientes} adicionais.";
        }

        public double ValorAdicional()
        {
            return _totalIngredientes * _precoAdicional;
        }

        public double ValorVenda()
        {
            return _precoBase + ValorAdicional();
        }

    }
}
