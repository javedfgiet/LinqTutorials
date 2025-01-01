using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     Element Operators: Element Opertaor return particular element from the sequence (collection)

    ************************************************************************************************************************
    *
    *
    * ElementAt          : Returns the element at a specified index in a collection.
    * ElementAtOrDefault : Return the element at a specifed index or a default value if the index is out of range.
    * 
    * First              : Returns the first element of a collection, or the first element that satisfies condition.
    * FirstOrDefault     : Returns the first element of a collection, or the first element that satisfies condition. 
    *                                  Returns a default value if index is out of range.
    *                                  
    * Last               : Returns the Last element of a collection, or Last element that satisfies condition.
    * LastOrDefault      : Returns the Last element of a collection, or Last element that satisfies condition. Return a default value if
    *                          no such element exist.
    *                          
    * Single             : Returns the only element of a collection, or the only element that sattifies a condition.
    * SingleOrDefault    : Returns the only element of a collection, or the only element that satisfies a condition.
    *                               Return a default value if no suchelement exists or the collection oes not contain exactly one element.
    *                      
    ************************************************************************************************************************ 
     */
    internal class ElementOperator
    {
        public void ElementAtOp()
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> stringList = new List<string>() { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("1st Element in intList : {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList :{0}", stringList.ElementAt(0));

            Console.WriteLine("2nd Element in intList : {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in strList : {0}", stringList.ElementAt(1));


            Console.WriteLine("3rd Element in intList : {0}", intList.ElementAt(2));
            Console.WriteLine("3rd Element in strList : {0}", stringList.ElementAt(2));

            Console.WriteLine("10th Element in the intList : {0}", intList.ElementAtOrDefault(9));
            Console.WriteLine("10th Element in strList : {0}", stringList.ElementAtOrDefault(9));

            Console.WriteLine("intList.ElementAt(9) throws an exception : Index Out of range");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(intList.ElementAt(9));
        }
    }
}
