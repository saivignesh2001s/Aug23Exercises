namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employees b1 = new employees();
           
            
                Console.WriteLine("Enter EmpNo");
                b1.empno=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Empname");
                b1.ename = Console.ReadLine();
                Console.WriteLine("Enter salary");
                b1.salary= Convert.ToSingle(Console.ReadLine());
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
                if (EmpNo == 0)
                {
                    Console.WriteLine("EmpNumber can't be null");
                }
                else
                {
                    EmpNo = value;
                }
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
                if (string.IsNullOrEmpty(Ename))
                {
                    Console.WriteLine("Name not valid");
                }
                else
                {
                    Ename = value;
                    
                }
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
                if (deptno == 0)
                {
                    Console.WriteLine("DeptNum can't be null");
                }
                else
                {
                    deptno = value;
                }
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