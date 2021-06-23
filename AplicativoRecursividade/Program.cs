using System;
using System.Collections.Generic;

namespace AplicativoRecursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            NumerosPrimos num = new NumerosPrimos();
            int numero;

            Console.WriteLine($"Testando metodo 'descobrirPrimosDesteNumero'" +
                $"\nDigite um numero: ");
            numero = int.Parse(Console.ReadLine());

            List<int> lista = num.descobrirPrimosDesteNumero(numero);

            Console.WriteLine("Lista de numeros primos do numero " + numero + "\n");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("[" + lista[i] + "] ");
            }
        }
    }
}
