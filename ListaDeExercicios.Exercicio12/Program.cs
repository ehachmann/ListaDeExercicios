namespace ListaDeExercicios.Exercicio12
{
    internal class Program
    {
        // Gerar e escreve os números ímpares entre 100 e 200
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Números Ímpares entre 100 e 200");
            Console.WriteLine();
            #endregion

            #region process
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} - ");
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
