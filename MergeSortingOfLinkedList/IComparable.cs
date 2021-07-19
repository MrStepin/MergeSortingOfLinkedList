using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MergeSortingOfLinkedList
{
    public interface IComparer<T>
    {
        int Compare(T object1, T object2);
    }
}
