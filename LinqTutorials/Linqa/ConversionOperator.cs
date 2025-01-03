using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * Conversion Operators : The conversion operators in LINQ are useful in converting the type of elements in sequence (collection).
     * There are three types of conversion operators:
     * As Operators (AsEnumerable and AsQueryable)
     * ToOperators (ToArray, ToDictionary, ToList and ToLookup)
     * Casting Operator (Casst and OfType)
     */
    internal class ConversionOperator
    {
        /*
         * The AsEnumerable and AsQueryable methods cast or convert a source object to IEnumerable<T> or IQueryable<T> respectively.
         */
        public void Get_AsOperator()
        {
            Student[] studentArray =
            {
                new Student (){StudentID=1,StudentName="John",Age=18 },
                new Student (){StudentID=2,StudentName="Steve",Age=21 },
                new Student (){StudentID=3,StudentName="Bill",Age=25 },
                new Student (){StudentID=4,StudentName="Ram",Age=20 },
                new Student (){StudentID=5,StudentName="Ron",Age = 30 }
            };
            ReportTypeProperties(studentArray);
            ReportTypeProperties(studentArray.AsEnumerable());
            ReportTypeProperties(studentArray.AsQueryable());

        }

        public void ReportTypeProperties<T>(T obj)
        {
            Console.WriteLine("Compile-time type : {0}", typeof(T).Name);

            Console.WriteLine("Actual type : {0}",obj.GetType().Name);
        }

        public void Get_Cast()
        {
            Student[] studentArray =
            {
                new Student (){StudentID=1,StudentName="John",Age=18 },
                new Student (){StudentID=2,StudentName="Steve",Age=21 },
                new Student (){StudentID=3,StudentName="Bill",Age=25 },
                new Student (){StudentID=4,StudentName="Ram",Age=20 },
                new Student (){StudentID=5,StudentName="Ron",Age = 30 }
            };
            ReportTypeProperties(studentArray);
            ReportTypeProperties(studentArray.Cast<Student>());
        }

        public void ToArray_ToList_ToDictionary()
        {
            IList<string> listArray = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Three"
            };

            string[] array = listArray.ToArray<string>();
            IList<string> list=array.ToList<string>();

            IList<Student> studentList = new List<Student>()
            {
                new Student(){StudentID=11,StudentName="John",Age=18 },
                new Student(){StudentID=2,StudentName="Steve",Age=21 },
                new Student(){StudentID=3,StudentName="Bill",Age=18},
                new Student(){StudentID=4,StudentName="Ram",Age=20},
                new Student(){StudentID=5,StudentName="Ron",Age=21}
            };

            IDictionary<int, Student> studentDict = studentList.ToDictionary<Student, int>(s => s.StudentID);
            
            foreach(var item in studentDict)
            {
                Console.WriteLine(item.Key +" "+item.Value.StudentName);
            }
        }
    }
}
