namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        // Crie um programa para calcular o volume de um Cilindro
        // V = π . r² . a
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            //processamento
            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            //output
            Console.WriteLine($"O volume do cilindro é: {volume}.");

            Console.ReadLine();
        }
    }
}
