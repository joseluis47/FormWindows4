using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
     class Teste
    {
        private int Percentual1 = 5;
        private int Percentual2 = 10;
        private int Percentual3 = 15;

        public double ValorFinal (double precoinicial, int tipoproduto)
        {
            double precofinal=0;
            switch(tipoproduto)
            {
                case 1:
                    precofinal = precoinicial + precoinicial * Percentual1 / 100;
                    break;
                case 2:
                    precofinal = precoinicial + precoinicial * Percentual2 / 100;
                    break;
                case 3:
                    precofinal = precoinicial + precoinicial * Percentual3 / 100;
                    break;

            }
            return precofinal;
        }
    }
}
