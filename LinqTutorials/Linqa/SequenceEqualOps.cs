using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * Sequence Equal : There is only one equality operator : SequenceEqual. The SequenceEqual method check whether the number of elements, 
     * value of each element and order of elements in two collections are equal or not.
     * --------------IF the Collection contains elements of primitive data types then it compares the value and the number of elements,
     * whereas collection with complex type elements, checks the reference of the objects. So, If the objects have the same reference then they 
     * considered as equal otherwise they are considered not equal.
     */
    internal class SequenceEqualOps
    {
        public void Get_SequenceEqual()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };
            IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            bool isEqual = strList1.SequenceEqual(strList2);
            Console.WriteLine(isEqual);

        }

        public void Get_SequenceComplex()
        {
            Student std = new Student() { StudentID = 1, StudentName = "Bill" };

            IList<Student> stdList1 = new List<Student>() { std };
            IList<Student> stdList2 = new List<Student>() { std };

            bool isEqual = stdList1.SequenceEqual(stdList2);
            Console.WriteLine(isEqual);

            Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };
            Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };
            IList<Student> studentList3 = new List<Student>() { std1 };
            IList<Student> studentList4 = new List<Student>() { std2 };
            isEqual = studentList3.SequenceEqual(studentList4,new StudentListComparer());

            Console.WriteLine("Comparing Complex Type : {0}",isEqual);


        }
    }

    internal class StudentListComparer : IEqualityComparer<Student>
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
            return obj.GetHashCode();
        }
    }
}
