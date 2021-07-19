using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortingOfLinkedList
{
    class MergeSorting<T>
    {
        private Element<T> _firstElement;
        private Element<T> _lastElement;

        public LinkedList<T> Sort(LinkedList<T> list)
        {
            if (list.Length() == 1)
            {
                return list;
            }
            int middle = list.Length() / 2;
            return Merge(Sort(list.Take(middle)), Sort(list.Skip(list.Length())));
        }

        private LinkedList<T> Merge(LinkedList<T> leftPart, LinkedList<T> rightPart)
        {
            LinkedList<T> merged = new LinkedList<T>();
            Element<T> currentElementOfLeftPart = leftPart._firstElement;
            Element<T> currentElementOfRightPart = rightPart._firstElement;

            for (int i = 0; i < leftPart.Length() + rightPart.Length(); i++)
            {
                if (currentElementOfLeftPart != null && currentElementOfRightPart != null)
                {
                    if (Comparator<T>.Compare(currentElementOfRightPart.Data, currentElementOfLeftPart.Data) == 0)
                    {
                        merged.Add(currentElementOfRightPart.Data);
                        currentElementOfRightPart = currentElementOfRightPart.Next;
                    }
                    else
                    {
                        merged.Add(currentElementOfLeftPart.Data);
                        currentElementOfLeftPart = currentElementOfLeftPart.Next;
                    }
                }
                else
                {
                    if (currentElementOfLeftPart != null)
                    {
                        merged.Add(currentElementOfLeftPart.Data);
                        currentElementOfLeftPart = currentElementOfLeftPart.Next;
                    }
                    else
                    {
                        merged.Add(currentElementOfRightPart.Data);
                        currentElementOfRightPart = currentElementOfRightPart.Next;
                    }
                }
            }
            return merged;
        }

    }
    class Comparator<T> : IComparer<Element<T>>
    {
        public int Compare(Element<T> object1, Element<T> object2)
        {
            Element<T> currentElementOfLeftPart = object2.Data;
            Element<T> currentElementOfRightPart = object1.Data;
            if (currentElementOfRightPart < currentElementOfLeftPart)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
