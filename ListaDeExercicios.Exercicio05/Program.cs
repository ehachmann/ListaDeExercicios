namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        // Calcular o salário total de um vendedor.
        static void Main(string[] args)
        {
            #region input
            Console.Write("Digite o salario base do funcionário: R$ ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o valor total de vendas do funcionário: R$ ");
            double valorVendas = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o percentual de comissão do funcionário: % ");
            double percentualComissao = double.Parse(Console.ReadLine());
            #endregion

            #region processamento  
            double comissao = (valorVendas * percentualComissao) / 100;
            double salarioTotal = salarioBase + comissao;
            #endregion

            #region output
            Console.WriteLine();
            Console.WriteLine($"O salário total do vendedor é R$ {salarioTotal} ");
            Console.ReadKey();
            #endregion             
        }
    }
}
