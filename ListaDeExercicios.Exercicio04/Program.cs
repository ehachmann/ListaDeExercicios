namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        // Converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            #region input
            Console.Write("Digite a temperatura que deseja converter de Celsius para Fahrenheit: ");
            double celsius = double.Parse(Console.ReadLine());
            #endregion

            #region process
            double fahrenheit = (celsius * 1.8) + 32;
            #endregion

            #region output
            Console.WriteLine();
            Console.WriteLine($"A temperatura {celsius}°C é equivalente a {fahrenheit}°F.");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
            #endregion

        }
    }
}
