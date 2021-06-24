using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoRecursividade
{
    public class NumerosPrimos
    {

        public NumerosPrimos()
        {
            
        }

        public List<int> descobrirPrimosDesteNumero(int valor, List<int> numerosPrimosDoValor = null, int contador = 0)
        {
            if (numerosPrimosDoValor == null)
            {
                //numerosPrimosDoValor == Numeros primos divisiveis pelo valor.
                numerosPrimosDoValor = new List<int>();
                contador = valor - 1;

                //Resolver de forma ineficiente o problema do numero primo 2 nao ser adicionado a lista.
                if(valor >= 2 && valor % 2 == 0) numerosPrimosDoValor.Add(2);
            }
            
            if (contador > 1) 
            {
                
                if (valor % contador != 0)
                {
                    //Realizar recursao para o proximo numero do 'contador'.
                    numerosPrimosDoValor = descobrirPrimosDesteNumero(valor,numerosPrimosDoValor,--contador);
                }
                else if (valor % contador == 0)
                {
                    //Verificar se o numero eh primo.
                    for (int i = 2, numeroASerVerificado = contador; i < numeroASerVerificado; i++)
                    {
                        if (numeroASerVerificado % i == 0)
                        {
                            break;
                        }
                        else if(i == numeroASerVerificado - 1)
                        {
                            numerosPrimosDoValor.Add(numeroASerVerificado);
                        }
                    }

                    //Realizar recursao para o proximo numero do 'contador'.
                    numerosPrimosDoValor = descobrirPrimosDesteNumero(valor, numerosPrimosDoValor, --contador);

                }
            }

            return numerosPrimosDoValor;
        }

    }
}
