namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma caixa retangular
        //VOLUME_DA_CAIXA = COMPRIMENTO * LARGURA * ALTURA
        static void Main(string[] args)
        {
            #region input de dados

            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region processamento
            decimal resultado = comprimento * largura * altura;
            #endregion

            #region output dos dados
            Console.WriteLine($"O volume da caixa é de {resultado}.");
            #endregion

            Console.ReadLine();
        }
    }
}
