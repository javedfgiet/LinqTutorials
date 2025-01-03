using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * Set Operator:Union =====>  The Union extension method requires two collections and return a new collection that include distinct
     * elements from both the collection.
     */
    internal class UnionOps
    {
        public void Get_UnionOps()
        {
            IList<string> strLsit1 = new List<string>() { "One", "Two", "three", "Four" };
            IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };
            var result=strLsit1.Union(strList2);
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        public void GetUnion_students()
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

            var resultedColl= studentList1.Union(studentList2,new StudentUnionCompared());
            foreach(Student student in resultedColl)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }

    public class StudentUnionCompared : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if(x.StudentID == y.StudentID && x.StudentName.ToLower()==y.StudentName.ToLower())
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
