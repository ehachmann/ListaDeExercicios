namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        // Crie um programa para calcular o consumo de combustível por quilometro percorrido
        static void Main(string[] args)
        {
            // input de dados

            Console.Write("Digite a quilometragem atual do veículo: ");
            int quilometragemInicial = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite a quilometragem final da viagem: ");
            int quilometragemFinal = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite a quantidade de combustível consumida na viagem: ");
            int quantidadeCombustivel = int.Parse(Console.ReadLine());

            // processamento

            int consumo = (quilometragemFinal - quilometragemInicial) / quantidadeCombustivel;

            // output

            Console.WriteLine();
            Console.WriteLine($"O consumo de combustível por quilômetro percorrido é: {consumo} km/l.");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();

        }
    }
}
