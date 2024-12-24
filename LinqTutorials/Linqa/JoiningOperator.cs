using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
    JOIN : The Join operator joins two sequences (collections) and produce a result.
    The Join operator operates on two collections, inne collectoin and outer collection.
    It return a new collection that contain elements from both the collections 
    which satisfies specified expression.
    It is the same as iner join of SQL.
     */
    public class JoiningOperator
    {
        public IEnumerable<string> JoinOperator()
        {
            IList<string> strList1 = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four"
            };

            IList<string> strList2 = new List<string>()
            {
                "One",
                "Two",
                "Five",
                "six"
            };

            var innerJoin = strList1.Join(strList2,
                                        str1 => str1,
                                        str2 => str2,
                                        (str1, str2) => str1);
            return innerJoin;
        }


        public void JoinQueryOperator()
        {
            IList<StudentList> studentLists = new List<StudentList>()
            {
                new StudentList {StudentID=1,StudentName="John",StandardId=1 },
                new StudentList {StudentID=2,StudentName="Moin",StandardId=1 },
                new StudentList {StudentID=3,StudentName="Bill",StandardId=2 },
                new StudentList {StudentID=4,StudentName="Ram",StandardId=2 },
                new StudentList {StudentID=5,StudentName="Ron" }
            };

            IList<Standard> standards = new List<Standard>()
            {
                new Standard {StandardID=1,StandardName="std1" },
                new Standard {StandardID=2,StandardName="std2" },
                new Standard {StandardID=3,StandardName="std3}" }
            };

            var innerJoin = studentLists.Join(
                                            standards,
                                            student => student.StandardId,
                                            std => std.StandardID,
                                            (student, std) =>
                                            new
                                            {
                                                StudentName = student.StudentName,
                                                StandardName = std.StandardName
                                            });

        }





        
    }

    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }

    public class StudentList
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardId { get; set; }

    }
}