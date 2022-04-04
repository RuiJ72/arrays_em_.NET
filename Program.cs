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
            int[] arrayCopia = new int[1]; // Vamos passar os vaores do array anterior para este novo array


            int valorProcurado = 0; // Experimentar com outros valores além de 0

            bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado); //retorna verdadeiro uma vez que todos são maiores que dez


            if (TodosMaiorQue)
            {
                System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            }
            else
            {
                System.Console.WriteLine("Existem valores que não são maiores q o valor procurado {0}", valorProcurado);
            }

            // int valorProcurado = 10; //Se passarmos o valor 10, que não existe, retornará a outra mensagem
            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrado o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("valor não encontrado; {0}", valorProcurado);
            // }

            //System.Console.WriteLine("Array Original:");
            //op.ImprimirArray(array);

            // Ordenando pelo BubbleSort(ref, array)
            // op.Ordenar(ref array);
            
            //System.Console.WriteLine("Array Ordenado:");
            //op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia:");
            // op.ImprimirArray(array);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia:");
            // op.ImprimirArray(arrayCopia);
        }
    }
}

// Método Sort
// O array foi igualmente ordenado mas pelo método sort

/* Como o array original é inferior ao tamanho passado como limite para a cópia [10] 
temos o retorno do array original e o restante dos indícies são zeros*/

