namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        // Calcular a média ponderada de duas provas
        static void Main(string[] args)
        {
            #region imput
            Console.Write("Informe a 1º nota do Aluno: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o peso da 1º nota: ");
            int peso1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Informe a 2º nota do Aluno: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o peso da 2º nota: ");
            int peso2 = int.Parse(Console.ReadLine());
            #endregion

            #region processamento
            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
            #endregion

            #region output
            Console.WriteLine();
            Console.WriteLine($"A média ponderada das duas notas é : {mediaPonderada}");
            Console.ReadKey();
            #endregion
        }
    }
}
