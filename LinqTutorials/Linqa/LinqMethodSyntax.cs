using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    public class LinqMethodSyntax
    {
        IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
            };

        public IEnumerable<string> QuerySyntax()
        {
            var result = stringList.Where(s => s.Contains("Tutorials"));
            return result;

        }

        public IEnumerable<Student> MethodSyntaxtObj()
        {
            IList<Student> studentList = new List<Student>()
            {
             new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
             new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
             new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
             new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
             new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            var teenAgerStudent = studentList.Where(s=>s.Age>12 && s.Age<20).ToList<Student>();
            return teenAgerStudent;
        }
    }
}
