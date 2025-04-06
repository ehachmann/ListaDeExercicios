namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        // Escreva o fatorial de um número inteiro positivo N.
        // O fatorial de N é o produto de todos os números inteiros positivos menores ou iguais a N.
        // Por exemplo, o fatorial de 5 é 5 * 4 * 3 * 2 * 1 = 120.

        static void Main(string[] args)
        {
            #region input
            Console.Write("Escreva um número para calcular o seu Fatorial: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine();
            #endregion
        
            #region processamento
            if (numero < 0)
            {
                Console.WriteLine("Número inválido! O número deve ser maior ou igual a zero.");
                Console.ReadKey();
                return;
            }
            else if (numero == 0)
            {
                Console.WriteLine("O fatorial de 0 é 1.");
                Console.ReadKey();
                return;
            }
            else 
            {
                Fatorial(numero);
            }

            double num = numero;
            Console.Write($"O fatorial de {numero} é:");
            Console.WriteLine();

            for (int i = 1; i <= num; i++)
            {   
                Console.Write($"{numero}");
                numero = numero - 1;
                if (numero < 1)
                    Console.WriteLine($" = {Fatorial(num)}");
                else
                    Console.Write(" * ");
            }
            Console.ReadKey();
            #endregion
        }

        public static double Fatorial(double numero)
        {
            double resultado = 1;
            while (numero != 1)
            {
                resultado = resultado * numero;
                numero = numero - 1;
            }
            return resultado;
        }
    }
}
