using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoRecursividade
{
    class NumerosPrimos
    {

        public List<int> descobrirPrimosDesteNumero(int valor, List<int> numerosPrimosDoValor = null, int contador = 0)
        {

            //TO DO: Colocar este if como ultimo a ser verificado focando 
            if (numerosPrimosDoValor == null) 
            {
                //numerosPrimosDoValor == Numeros primos divisiveis pelo valor.
                numerosPrimosDoValor = new List<int>();
            }


            //Verificar se o numero eh primo.
            for (int i = 2, numeroASerVerificado = 0; i < numeroASerVerificado; i++)
            {
                if (i % numeroASerVerificado == 0)
                {
                    break;
                }
                else if(i == numeroASerVerificado - 1)
                {
                    numerosPrimosDoValor.Add(numeroASerVerificado);
                }
            }

            return numerosPrimosDoValor;
        }

    }
}
