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
            var result = new JoiningOperator();
            foreach (var item in result.JoinOperator())
            {
               Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
