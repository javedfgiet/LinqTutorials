using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     The Linq SelectMany Method in C# is used to project each element of a sequence or 
    collection of Data soure to an IEnumarbale<T> type and flatten the resulting sequence into one 
    sequence. 
     */
    internal class SelectManyClass
    {

        public void GetResult()
        {
            IList<string> list = new List<string>() { "Javed", "Ahmad" };
            var result = from str in list
                         from ch in str
                         select ch;

            foreach (var ch in result)
            {
                Console.WriteLine(ch + " ");
            }
        }


        public void GetStudents()
        {
            IList<BatchList> batchList = new List<BatchList>()
            {
                new BatchList() { Id=1,Name="James",Email="James@j.com",
                           Programming=new List<string>(){"C#","Java","C++"} },
                new BatchList() { Id=2,Name="Sam",Email="sam@s.com",
                           Programming=new List<string>(){"WCF","SQL Server","C#" } },
                new BatchList(){Id=3,Name="Sara",Email="sara@s.com",
                            Programming=new List<string>{"MVC","Java","LINQ"}},
                new BatchList(){Id=4,Name="Patrika",Email="patrika@p.com",
                            Programming=new List<string>{"ADO.Net","C#","LINQ"}}
            };


            // Using Method Syntax
            List<string> result = batchList.SelectMany(s => s.Programming).ToList();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }





        }
    }

    public class BatchList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<string> Programming { get; set; }
    }
}
