namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula a Área de um Quadrado ou Retângulo");
            Area p = new Area();
            Console.WriteLine("Digite o valor da Altura:");
            p.Altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da Base:");
            p.Baseret = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O valor da área será: ");
            Console.WriteLine(p.CalculaArea());
            //Console.WriteLine(p.CalculaArea2());
        }
    }
}