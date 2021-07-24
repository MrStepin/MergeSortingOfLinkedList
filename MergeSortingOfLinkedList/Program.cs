using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortingOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.Add(1);
            testList.Add(5);
            testList.Add(7);
            testList.Add(9);
            //testList.Add(2);
            //testList.Add(2);
            //testList.Add(8);
            //testList.Add(3);
            //testList.Add(1);
            //testList.Add(8);
            //testList.Add(4);
            //testList.Add(6);

            MergeSorting<int> mergeSorting = new MergeSorting<int>();
            mergeSorting.Sort(testList).Print();
        }
    }
}
