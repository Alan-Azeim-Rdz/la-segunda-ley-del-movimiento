using la_segunda_ley_del_movimiento;

namespace AppClassTest
{
    internal class Progrma
    {
        public static void Main(string[] args)
        {
            Mass m = new Mass();
            Console.WriteLine("What is the mass: ");
            m.M = Convert.ToDouble(Console.ReadLine());

            aceleration a = new aceleration();
            Console.WriteLine("What is the aceleration: ");
            a.A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(m.ToString() + a.ToString() +" Force: "+ a.A * m.M);
        }
    }
}

