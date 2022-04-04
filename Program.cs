using System;
using Colecoes.helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 8, 1, 9};
            
            System.Console.WriteLine("Array Original:");
            op.ImprimirArray(array);

            op.OrdenarBublleSort ( array );
            
            System.Console.WriteLine("Array Ordenado:");
            op.ImprimirArray(array);
        }
    }
}
