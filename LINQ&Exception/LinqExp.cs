using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Exception
{
    public class LinqExpList
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string  Department { get; set; }
        public long Salary { get; set; }
    }
    public class LinqExp
    {
        List<LinqExpList> list = new List<LinqExpList>();
        public void Add1()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the number of records");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the First Name : ");
                string firstname = Console.ReadLine();

                Console.WriteLine("Enter the Second Name : ");
                string secondname = Console.ReadLine();

                Console.WriteLine("Enter the Age : ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Department : ");
                string department = Console.ReadLine();

                Console.WriteLine("Enter the Salary : ");
                long salary = Convert.ToInt64(Console.ReadLine());

                list.Add(new LinqExpList { FirstName  = firstname, LastName = secondname, Age = age, Department = department, Salary = salary });
                
            }
        }
        public void Display1()
        {
            // Select Function
            //var dis = list.Select(x => new { x.FirstName, x.LastName, Age = x.Age, Department = x.Department, Salary = x.Salary });

            // OrderBy Function
            //list = list.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList();

            // Filter Function
            //list = list.Where(x => x.FirstName == "vishal" && x.Age>20).ToList();

            // First fetch
            //try
            //{
            //    LinqExpList l = list.First(x => x.FirstName == "vishal");

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(" Not Found. ");
            //}
            //finally
            //{
            //    Console.WriteLine("This is Final Block");
            //}

            // FirstOrDefault Function 
            //LinqExpList l = list.FirstOrDefault(x => x.FirstName == "vishal");

            // Last and LastOrDefault is Opposite to First and FirstOrDefault.

            // Single Function - it will return value from list if and only if it have single value in list if there is more it would show Exception 

            // Take Function 
            //list = list.Take(2).ToList();

            // Skip Function
            list = list.Skip(2).ToList();

            //ForEach Function
            //Console.WriteLine();
            Console.WriteLine("Value of List are : ");
            list.ForEach(x => Console.WriteLine("Name : {0} {1}, Age : {2}, Department : {3}, Salary : {4}", x.FirstName, x.LastName, x.Age, x.Department, x.Salary));

            //foreach (var value in l)
            //{
            //    Console.WriteLine(value);
            //}

            // Condition if First function does not get element in list.
            //if (l != null)
            //{
            //    Console.WriteLine("Name : {0} {1}, Age : {2}, Department : {3}, Salary : {4}", l.FirstName, l.LastName, l.Age, l.Department, l.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found.");
            //}



        }




    }
}
