namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int k;
            Console.WriteLine("Enter Numbers");
            i=Convert.ToInt32(Console.ReadLine());
            j=Convert.ToInt32(Console.ReadLine());
            Divide(i, j);
          
            Console.ReadLine();
        } 
        static void Divide(int k,int c)
        {
            try
            {
                int j;
                j=k / c;
                Console.WriteLine(j);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);
                
            }

        }
    }
}