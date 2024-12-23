using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
    The where operator (Linq Extension method) filters the collection based on given 
    criteria expression and return a new collection.
    The Criteria can be specified as lambda expression or Func delegate type.

     */
    public class WhereMethods
    {
        public IEnumerable<Student> GetStudents()
        {
            IList<Student> studentList = new List<Student>()
            {
             new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
             new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
             new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            Func<Student, bool> isTeenAger = delegate (Student s)
            {
                return s.Age > 12 && s.Age < 20;
            };

            var filterdResult = from s in studentList where isTeenAger(s) select s;
            return filterdResult;

        }

        public bool isTeenAger(Student s)
        {
            return s.Age>12 && s.Age < 20;
        }
    }
}
