using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     *  Concatenation Operator : Concat() method appends two sequqnces of same type and returns a new sequence (collection).
     */
    internal class ConcatOps
    {
        public void GetConcatOperator()
        {
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };

            var collection=collection1.Concat(collection2);
            foreach (var item in collection)
            {
                Console.WriteLine(item);

            }
        }
    }
}
