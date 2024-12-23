using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    public class Program
    {
        static void Main(string[] args)
        {

            WhereMethods obj = new WhereMethods();
            var result = obj.GetStudents();

            foreach (var item in result)
            {
                Console.WriteLine(item.StudentID + " " + item.StudentName + " " + item.Age);

            }
            Console.ReadLine();
        }
    }
}
