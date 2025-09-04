using XulambsFoods_2025_1.src;

namespace POO_N_Xulambs_Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza();

            p1.AdicionarIngrediente(1);
            Console.WriteLine(p1.EmitirCupom());

            Pedido pedido1 = new Pedido();
            Pedido pedido2 = new Pedido();

            pedido1.Adicionar(p1);

            pedido2.FecharPedido();
            pedido2.Adicionar(p1);

            Console.WriteLine(pedido1.Relatorio());
            Console.WriteLine(pedido2.Relatorio());
        }
    }
}
