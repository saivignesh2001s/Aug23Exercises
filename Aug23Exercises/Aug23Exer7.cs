namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter Numbers");
            i=Convert.ToInt32(Console.ReadLine());
            j=Convert.ToInt32(Console.ReadLine());
            try
            {
                int k = i / j;
                Console.WriteLine(k);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }
            Console.ReadLine();
        } 
    }
}