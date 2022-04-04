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
            
            
            {
                var linha = string.Join(",", array);
                System.Console.WriteLine(linha);
            }
        
        }
    
    }
}
// Concatenando os elementos em uma mesma linha 

// Colocar um BreakPoint na linha 11 e observar a lógica do código dando F5
// Após Colocar o BraekPoint na linha 25 3 debugar. Observar o comportamnto