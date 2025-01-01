using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
    *                                  
    * Last               : Returns the Last element of a collection, or Last element that satisfies condition.
    * LastOrDefault      : Returns the Last element of a collection, or Last element that satisfies condition. 
    *                      Return a default value if no such element exist.
    *                          
    * 
     */
    internal class Last_LastOrDefault
    {
        public void LastOPs()
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> stringList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();


            Console.WriteLine("Last Element in intList : {0}", intList.Last());
            Console.WriteLine("Last Even Element in intList : {0}", intList.Last(x => x % 2 == 0));
            Console.WriteLine("Last Element in strList : {0}", stringList.Last());
            Console.WriteLine("emptyList.Last() throws an InvalidOperationException");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(emptyList.Last());
            
        }

        public void LastAndLastOrDefault()
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> stringList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("Last Element in intList : {0}",intList.LastOrDefault());

            Console.WriteLine("Last Even ELement in intList : {0}",intList.LastOrDefault(x=>x%2==0));
            Console.WriteLine("Last Element in strList : {0}",stringList.LastOrDefault());

            Console.WriteLine("Last Element in emptyList : {0}",emptyList.LastOrDefault());

            IList<string> stringList1 = new List<string>() { "Two", "Three", "Four", "Five" };

            IList<string> stringList2 = new List<string>() { null, "Two", "Three", "Four", "Five" };

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(stringList1.LastOrDefault(s => s.Contains("T")));

            // If a collection include null element then the LastOrDefault()
            // throw an exception while evaluating the specifiied condition.

            Console.WriteLine(stringList2.LastOrDefault(s=>s.Contains("T")));



        }
    }
}
