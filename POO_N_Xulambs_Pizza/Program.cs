using XulambsFoods_2025_1.src;

namespace POO_N_Xulambs_Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza();
            Pizza p2 = new Pizza();
            Pizza p3 = new Pizza();

            p1.AdicionarIngrediente(1);
            p2.AdicionarIngrediente(4);
            p3.AdicionarIngrediente(5);
            //Console.WriteLine(p1.EmitirCupom());

            Pedido pedido1 = new Pedido();
            Pedido pedido2 = new Pedido();

            pedido1.Adicionar(p1);
            pedido1.Adicionar(p2);
            pedido1.Adicionar(p3);

            pedido2.FecharPedido();
            pedido2.Adicionar(p1);

            Console.WriteLine(pedido1.Relatorio());
            Console.WriteLine(pedido2.Relatorio());
        }
    }
}
