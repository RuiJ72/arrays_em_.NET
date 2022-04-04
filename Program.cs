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
            int[] arrayCopia = new int[10]; // Vamos passar os vaores do array anterior para este novo array


            //System.Console.WriteLine("Array Original:");
            //op.ImprimirArray(array);

            // Ordenando pelo BubbleSort(ref, array)
            // op.Ordenar(ref array);
            
            //System.Console.WriteLine("Array Ordenado:");
            //op.ImprimirArray(array);

            System.Console.WriteLine("Array antes da cópia:");
            op.ImprimirArray(array);

            op.Copiar(ref array, ref arrayCopia);
            System.Console.WriteLine("Array após a cópia:");
            op.ImprimirArray(arrayCopia);
        }
    }
}

// Método Sort
// O array foi igualmente ordenado mas pelo método sort

/* Como o array original é inferior ao tamanho passado como limite para a cópia [10] 
temos o retorno do array original e o restante dos indícies são zeros*/

