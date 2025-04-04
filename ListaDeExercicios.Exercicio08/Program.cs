namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

            #region input
            Console.Write("Insira o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Insira o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Insira o valor de C: ");
            double c = double.Parse(Console.ReadLine());
            #endregion

            #region processamento e output
            double conta = a + b;

            Console.WriteLine();

            if (conta > c)
            {
                Console.WriteLine("A soma de A e B é maior que C");
            }
            else if (conta == c)
            {
                Console.WriteLine("A soma de A e B é igual a C");
            }
            else 
            { 
            Console.WriteLine("A soma de A e B é menor que C");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
