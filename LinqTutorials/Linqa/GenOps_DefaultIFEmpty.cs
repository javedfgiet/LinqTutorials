using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * DefaultIFEmpty() : TheDefaultIfEmpty() method return a new collection with the default value If the given collection
     * on which DefaultIfEmpty() is invoked is empty.
     * ***************Another overload method of DefaultIFEmpty() takes a value parameter that should be replaced with default value.
     */
    internal class GenOps_DefaultIFEmpty
    {
        public void Get_DefaultIfEmpty()
        {
            IList<string> emptyList=new List<string>();
            var newList1=emptyList.DefaultIfEmpty();
            var newList2=emptyList.DefaultIfEmpty("None");

            Console.WriteLine("Count : {0}",newList1.Count());
            Console.WriteLine("Value :{0}",newList1.ElementAt(0));

            Console.WriteLine("COunt :{0}",newList2.Count());
            Console.WriteLine("Value : {0}",newList2.ElementAt(0));

        }
    }
}
