using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortingOfLinkedList
{
    class MergeSorting<T> where T: IComparable<T>
    {
        private Element<T> _firstElement;
        private Element<T> _lastElement;

        public LinkedList<T> Sort(LinkedList<T> list)
        {
            int lengthOfList = list.Length();
            if (lengthOfList == 1)
            {
                return list;
            }
            int middle = lengthOfList / 2;
            var leftPart =  list.Take(middle);
            Element<T> firstElementOfRightPart = leftPart.Item2;
            LinkedList<T> rightPart = list.Skip(leftPart.Item2, lengthOfList, lengthOfList - middle);
            return Merge(Sort(leftPart.Item1), Sort(rightPart));
        }

        public LinkedList<T> Merge(LinkedList<T> leftPart, LinkedList<T> rightPart)
        {
            LinkedList<T> merged = new LinkedList<T>();
            Element<T> currentElementOfLeftPart = leftPart._firstElement;
            Element<T> currentElementOfRightPart = rightPart._firstElement;
            int lengthOfLeftPart = leftPart.Length();
            int lengthOfRightPart = rightPart.Length();

            for (int i = 0; i < lengthOfLeftPart + lengthOfRightPart; i++)
            {
                if (currentElementOfLeftPart != null && currentElementOfRightPart != null)
                {
                    if (currentElementOfRightPart.Data.CompareTo(currentElementOfLeftPart.Data) == -1)
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
}
