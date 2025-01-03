using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * Skip : Skips elements up to a specified position starting from the first element in a sequence.
     * 
     * SkipWhile : Skips elements based on a condition until an element does not satisfy the conition.
     * ---------If the first element itself doesnt satisfy the condtion, it then skip 0 element and return all the elements 
     * in the sequence.
     * 
     * * SkipWhile() extension method in Linq skip elements in the collection till the specified condition is true
     */
    internal class PO_Skip_SkipWhile
    {
        public void Get_Skip()
        {
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var newList = strList.Skip(2);

            foreach (string str in newList)
            {
                Console.WriteLine(str);
            }
        }

        /*
         * SkipWhile() extension method in Linq skip elements in the collection till the specified condition is true.
         */
        public void Get_SkipWhile()
        {
            IList<string> strList = new List<string>() { "One", "One", "Two", "One", "Three", "Four", "Five", "Six" };

            var result = strList.SkipWhile(s => s.Contains("One"));
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
