namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employees b1 = new employees();
           
            
                Console.WriteLine("Enter EmpNo");
                b1.EmpNo=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Empname");
                b1.Ename = Console.ReadLine();
                Console.WriteLine("Enter salary");
                b1.Salary= Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter DeptNo");
                b1.Dno = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Print the details");
                b1.display();
            
            Console.ReadLine();
            
                
            
        }
    }
    struct employees
    {
        public int EmpNo;
        public string Ename;
        public float Salary;
        public int deptno;
        public int empno
        {
            set
            {
                EmpNo = value;
            }
            get
            {
                return EmpNo;
            }
        }
        public string ename
        {
            set
            {
                Ename = value;
            }
            get
            {
                return Ename;
            }
        }
        public float salary
        {
            set
            {
                Salary = value;
            }
            get
            {
                return Salary;
            }
        }
        public int Dno
        {
            set
            {
                deptno = value;
            }
            get
            {
                return deptno;
            }
        }

       

            public void display()
        {
            Console.WriteLine("{0} {1} {2} {3}\n",EmpNo,Ename,Salary,deptno);
        } 
    }
}