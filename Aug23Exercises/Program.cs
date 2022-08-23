namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            students[] arr = new students[4];
            int k;
            string bookname;
            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine("Enter RollNo");
                arr[i].rollno=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter studentname");
                arr[i].StudentName = Console.ReadLine();
                
            }
            Console.WriteLine("Enter the details");
            for(int i = 0; i < 4; i++)
            {
                arr[i].display();
            }
            Console.ReadLine();
            
                
            
        }
    }
    struct students
    {
        public int RollNo;
        public string Student;
        public int rollno
        {
            set
            {
                RollNo = value;
            }
            get
            {
                return RollNo;
            }
        }
        public string StudentName
        {
            set
            {
                Student = value;
            }
            get
            {
                return Student;
            }
        }
       public void display()
        {
            Console.WriteLine("{0} {1}\n",RollNo,Student);
        } 
    }
}