namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        // Verificar se um número é primo
        static void Main(string[] args)
        {
            int divisores = 0;

            #region input
            Console.WriteLine("Um número é considerado primo se ele,");
            Console.WriteLine("somente pode ser dividido por 1 e por ele mesmo!");
            Console.WriteLine();
            Console.Write("Digite um número para verificar se ele é primo: ");
            int numero = int.Parse(Console.ReadLine());
            #endregion

            #region processamento
            for (int i = 1; i <= numero; i++) 
            {
                if (numero % i == 0)
                    divisores++;
            }
            #endregion

            #region output
            Console.WriteLine();

            if (divisores == 2)
            {
                Console.WriteLine($"O número {numero} é um número primo!");
            }else 
                Console.WriteLine($"O número {numero} não é um número primo!");

            Console.ReadKey();
            #endregion

        }
    }
}
