namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcular o IMC - Índice de Massa Corporal

            string resultado;

            #region input
            Console.Write("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());
            #endregion

            #region processamento
            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
            {
                resultado = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                resultado = "Peso normal";
            }
            else if (imc > 25 && imc <= 30)
            {
                resultado = "Acima do Peso";
            }
            else
            {
                resultado = "Obeso";
            }
            #endregion

            #region output
            Console.WriteLine();
            Console.WriteLine($"O IMC é: {imc}");
            Console.WriteLine();
            Console.WriteLine($"Classificação: {resultado}");
            Console.ReadKey();
            #endregion
        }
    }
}
