using System.Collections.Generic;
using System.Linq;

namespace Linqa
{
    public class OrderByOperators
    {
        IList<Student> studentList = new List<Student>()
            {
             new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
             new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
             new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
        public IEnumerable<Student> OrderByOpMethod()
        {
            var orderByResult = from s in studentList
                                orderby s.StudentName
                                select s;

            return orderByResult;
        }

        public IEnumerable<Student> OrderByDescendingOperator()
        {
            var orderByResult = from s in studentList
                                orderby s.StudentName descending
                                select s;

            return orderByResult;
        }

        /*
         Multiple Sorting : 
        You can sort the collection on multiple fields seperated by comma. 
        The given collection would be first sorted based on the first field and then if value of
        first field would be the same for two elements then it would use second field for 
        sorting and so on.
         */
        public IEnumerable<Student> OrderByMultipleSorting()
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



            var orderByResult = from s in students orderby s.StudentName,s.Age select s;
            return orderByResult;


        }
    }
}
