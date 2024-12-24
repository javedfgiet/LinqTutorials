using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     ToLookup is the same as GroupBy; T
     The only diffrence is GroupBy execution is deferred,
     Whereas ToLookup execution is immediate.
     ToLookup is only applicable in Method Syntax not in query syntax.
     */
    internal class ToLookUp
    {
        public void ToLookUpMethodSyntax()
        {
            IList<Student> students = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };

            var result=students.ToLookup(s=>s.Age).AsEnumerable();
        }
    }
}
