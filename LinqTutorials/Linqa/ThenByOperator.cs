using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    public class ThenByOperator
    {
        public IEnumerable<Student> ThenBySorting()
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



            var orderByResult = students.OrderBy(x => x.StudentName).ThenBy(x => x.Age);
            return orderByResult;


        }
    }
}
