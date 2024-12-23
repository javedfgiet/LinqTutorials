using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     OfType operator filters the collection based on the ability to cast an element in
     a collection to a speified type.
     */
    public class OFtype
    {
        public IEnumerable<string> OftypeResult()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var result = from s in mixedList.OfType<string>() select s;
            return result;

            
        }
    }
}
