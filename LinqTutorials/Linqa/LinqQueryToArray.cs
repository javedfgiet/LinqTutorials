using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    public class LinqQueryToArray
    {
        public void LinqQuery()
        {
            //Data Source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query
            var myLinqQuery = from name in names where name.Contains('a') select name;

            //Query execution
            foreach (var item in myLinqQuery)
            {
                Console.WriteLine(item);
            }

        }
    }
}
