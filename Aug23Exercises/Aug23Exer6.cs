namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deptname=" ";
            Console.WriteLine("Enter deptname");
            deptname=Console.ReadLine();
            int k;

            switch (deptname)
            {
                case "Purchases":
                    k = (int)deptnames.Purchases;
                    Console.WriteLine(k);
                    break;
                case "Sales":
                    k = (int)deptnames.Sales;
                    Console.WriteLine(k);
                    break;
                case "Training":
                    k = (int)deptnames.Training;
                    Console.WriteLine(k);
                    break;
                case "Accounts":
                    k = (int)deptnames.Accounts;
                    Console.WriteLine(k);
                    break;
                    default:
                    break;

            }

            Console.ReadLine();
           
           
            
            
                
            
        }
    }
    enum deptnames
    {
        Purchases=1,
        Sales=2,
        Training=3,
        Accounts=4


    }
    
}