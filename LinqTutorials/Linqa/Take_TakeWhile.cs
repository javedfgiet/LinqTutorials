using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * The Take() : extension method return the specified number of element starting from the first element
     * 
     * TakeWhile() : extension method returns element from the given collection till the specified condition is true.
     * 
     */
    internal class Take_TakeWhile
    {
        public void Get_Take()
        {
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var newList = strList.Take(3);

            foreach (string str in newList)
            {
                Console.WriteLine(str);
            }
        }

        public void Get_TakeWhile()
        {
            IList<string> strList = new List<string>() { "Three", "Four", "Five", "Hundred" };
            var result = strList.TakeWhile(s => s.Length>4);
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
