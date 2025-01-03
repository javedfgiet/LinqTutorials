using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * Intersect extension method : The inntersect extension method require two collections. 
     * It return a new collection that include common elements 
     * that exist in both the collection.
     */
    public class IntersectOps
    {
        public void Get_IntesectOps()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            var result = strList1.Intersect(strList2);

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        public void Get_Intesect_Students()
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
                 new Student(){ StudentID = 3,StudentName="Bill",Age=25 },
                new Student{ StudentID = 5,StudentName="Ron",Age=19 }
            };

            var result = studentList1.Intersect(studentList2, new StdComparer());
            foreach (Student student in result)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }

    public class StdComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
            {
                return true;

            }
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}
