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
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(5);
            list.Add(7);
            list.Add(9);
            list.Add(2);
            list.Add(2);
            list.Add(8);
            list.Add(3);
            list.Add(1);
            list.Add(8);
            list.Add(4);
            list.Add(6);

            MergeSorting<int> mergeSorting = new MergeSorting<int>();
            mergeSorting.Sort(list).Print();
        }
    }
}
