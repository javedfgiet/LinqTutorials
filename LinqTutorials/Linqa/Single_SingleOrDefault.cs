using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqa
{
    /*
     * The Single return only element from a collection, or theonly element that satisfies the specified condtion.
     * If a given collection includes no elements or more than one element then Single throws InvalidOperationException.
     * 
     * TheSingleOrDefault method does the same thing as Single method. The only difference is that it return default value
     * of the data type of a collection is empty, include more than once element or finds no element or more than one
     * element fo the specified condition.
     
     */
    internal class Single_SingleOrDefault
    {
        public void Get_SingleResult()
        {
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<int> emptyList = new List<int>();

            Console.WriteLine("The only element in oneElementList : {0}", oneElementList.Single());
            Console.WriteLine("The Only Element in OneLementList : {0}",oneElementList.SingleOrDefault());

            Console.WriteLine("Element in emptyList : {0}",emptyList.SingleOrDefault());

            Console.WriteLine("The Only Element which is less than 10 in intList: {0}", intList.Single(i => i < 10));

            Console.WriteLine("---------------Following will Throw Exception-------------------");

            Console.WriteLine("The Only Element in intList  : {0}", intList.Single());
            Console.WriteLine("The Only Element in intList : {0}", intList.SingleOrDefault());
            Console.WriteLine("The Only Element in emptyList : {0}",emptyList.Single());

        }

        public void Get_SingleOrDefault()
        {
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            // following throws error because list contains more than one lement which is less than 100

            //Console.WriteLine("Element Less than 100 in intList : {0}",intList.Single(x=>x < 100));

            //following throws error because list contain more than one element which is less than 100
            //Console.WriteLine("Element Less than 100 in intList : {0}", intList.SingleOrDefault(x => x < 100));

            //Following throws error bcz list contains more than one lement
            //Console.WriteLine("The Only Element in intList : {0}", intList.Single());


            //following throws error because list does not contain any elemnt
            //Console.WriteLine("The Only Elemnt in the emptyList : {0}", emptyList.Single());
            Console.WriteLine("The Only Elemnt in the emptyList : {0}", emptyList.SingleOrDefault());


        }

     
    }
}
