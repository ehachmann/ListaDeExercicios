namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que calcule a sequência de Fibonacci

            int x = 1, y = 0, z = 0;

            #region input
            Console.Write("Digite o número de termos da sequência de Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());
            #endregion

            #region process and output
            Console.WriteLine();
            Console.WriteLine("Sequência de Fibonacci:");
            Console.WriteLine("0");
            Console.WriteLine("1");
            for (int i = 2; i < numero; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                y = x;
                x = z;
            }
            Console.ReadLine();
            #endregion
        }
    }
}


