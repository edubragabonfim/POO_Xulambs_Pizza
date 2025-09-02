namespace POO_N_Xulambs_Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza();

            p1.AdicionarIngrediente(5);
            Console.WriteLine(p1.EmitirCupom());
        }
    }
}
