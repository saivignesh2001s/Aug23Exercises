namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter Numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            addition(a, b);
          
            Console.ReadLine();
        }
        static void addition(int c, int k)
        {
            Console.WriteLine("Sum={0}", c+k);

        }
    }
}