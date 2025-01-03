using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * LINQ:Except ==> The Except() method requires two collections. It return a new collection with elements
     * from the first collection which does not exist in the second collection (parameter collection).
     */
    internal class ExceptOps
    {
        public void ExceptOperator()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            var result=strList1.Except(strList2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void ExceptOpsWithCType()
        {
            IList<Student> studentList1 = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=18},
                new Student(){StudentID = 2,StudentName="Steve",Age=15 },
                new Student(){ StudentID = 3,StudentName="Bill",Age=25 },
                new Student{ StudentID = 5,StudentName="Ron",Age=19 }
            };

            IList<Student> studentList2 = new List<Student>()
            {
                new Student(){StudentID = 1,StudentName="John",Age=18},
                new Student{ StudentID = 5,StudentName="Ron",Age=19 }
            };

            var result=studentList1.Except(studentList2,new StudentComp());

            foreach(var item in result)
            {
                Console.WriteLine(item.StudentName);
            }
        }


    }
    public class StudentComp : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if(x.StudentID == y.StudentID) 
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}
