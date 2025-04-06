namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //informar na tela se é par ou ímpar

            #region input
            Console.Write("Informe o número que deseja verificar se ele é Par ou Ímpar: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            #endregion

            #region processamento
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é Par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é Ímpar.");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
