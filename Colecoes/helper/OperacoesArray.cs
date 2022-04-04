using System;

namespace Colecoes.helper
{

    public class OperacoesArray
    {

         //Implementação do BubleeSort
        public void OrdenarBublleSort(int[] array)
        {
           
            int temp = 0; // variável temporária

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        
        
        
        
        public void ImprimirArray(int[] array)
        
           
           
            {
                var linha = string.Join(",", array);
                System.Console.WriteLine(linha);
            }
        
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array); // Importando a classe Array. Segurar crtl +c
        }

        public void Copiar(ref int[] array, ref int[]arrayDestino) 
        {
            Array.Copy(array, arrayDestino, array.Length); //No último parãmetro podemos especificar quais elementos queremos copiar.
                                                           // No caso queremos uma cópia integral
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor); /* Vai retornar um valor booleano se existir : true se não : false*/
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }
    }
}





// Colocar um BreakPoint na linha 11 e observar a lógica do código dando F5
// Após Colocar o BraekPoint na linha 25 3 debugar. Observar o comportamnto