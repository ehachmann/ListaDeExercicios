namespace ListadeExercicios.Exercicio09
{
    internal class Program
    {

        // Ler três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            #region input
            Console.WriteLine($"Digite o 1º número: ");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o 2º número: ");
            numeros[1] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o 3º número: ");
            numeros[2] = int.Parse(Console.ReadLine());
            #endregion

            #region processamento
            for (int i = 0; i < 3; i++)
            {    
                for (int j = 0; j < 2; j++)
                {
                    var temp = numeros[j];
                    if (numeros[j] <= numeros[j + 1])
                    {
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;  
                      
                    }
                }
              
            }
            #endregion

            #region output
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Números digitados em ordem decrescente");
                Console.WriteLine($"O {i + 1}º número é: {numeros[i]}");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
