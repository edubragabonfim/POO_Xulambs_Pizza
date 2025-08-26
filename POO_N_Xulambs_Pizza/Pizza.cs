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

        public bool VerificarLimite(int novoTotal)
        {
            return novoTotal <= _maximoIngredientes;
        }

        public int AdicionarIngrediente(int quantidade)
        {
            if (!VerificarLimite(_totalIngredientes + quantidade))
            {
                _totalIngredientes += quantidade;
            }
            return _totalIngredientes;
        }

    }
}
