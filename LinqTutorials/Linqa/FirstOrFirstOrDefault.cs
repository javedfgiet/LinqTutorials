using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    internal class FirstOrFirstOrDefault
    {
        /*
         * 
        * First              : Returns the first element of a collection, or the first element that satisfies condition.
        * FirstOrDefault     : Returns the first element of a collection, or the first element that satisfies condition.
        * Returns a default value if index is out of range.
        * 
        */
        public void FirstOrFirstDefault()
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> stringList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> empltyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList {0}", intList.First(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList : {0}",stringList.First());
            Console.WriteLine("emptyList.First() throws an InvalidOperationException");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(empltyList.First());

        }
    }
}
