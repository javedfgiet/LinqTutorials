using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * Linq includes generation operator DefaultIFEmpty, Empty, Range & Repeat. The Empty, Range & Repeat methods are not extension
     * methods for IEnumerable or IQuerable but they are simply static methods defined in static class Enumerable.
     * 
     * Empty : Return an empty collection
     * Range : Generate collection of IEnumrable<T> type with specified number of elements with sequential values, 
     * ..............starting from first element.
     * 
     * Repeat : Generates a collection of IEnumerable<T> type with specified number of elements and each element contain same specified value.
     * 
     * 
     */
    internal class GenOps_EmptyRangeRepeat
    {
        public void Get_Empty()
        {
            var emptyCollection1=Enumerable.Empty<string>();
            var emptyCollection2=Enumerable.Empty<Student>();

            Console.WriteLine("Count : {0}",emptyCollection1.Count() );
            Console.WriteLine("Type : {0}",emptyCollection1.GetType().Name);

            Console.WriteLine("Count : {0}", emptyCollection2.Count());
            Console.WriteLine("Type :{0}",emptyCollection2.GetType().Name);
        }

        public void Get_Range()
        {
            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count : {0}", intCollection.Count());

            for (int i = 0; i < intCollection.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
            }
        }

        public void Get_Repeat()
        {
            var intCollection =Enumerable.Repeat<int>(10,10);
            Console.WriteLine("Total Count : {0}",intCollection.Count());

            for(int i = 0;i < intCollection.Count();i++)
            {
                Console.WriteLine("Value at index {0} : {1}",i,intCollection.ElementAt(i));
            }
        }
    }
}
