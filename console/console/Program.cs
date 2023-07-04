using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();

            Console.WriteLine(stu.fname);
            Console.WriteLine(stu.id);
            Console.WriteLine(stu.lname);


            Console.ReadLine();
        }
    }
}
