using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortingOfLinkedList
{
    public class LinkedList<T>
    {
        public Element<T> _firstElement;
        public Element<T> _lastElement;


        public void Add(T data)
        {
            Element<T> element = new Element<T>(data);

            if (_firstElement == null)
            {
                _firstElement = element;
            }
            else
            {
                _lastElement.Next = element;
            } 
            _lastElement = element;
        }

        public int Length()
        {
            Element<T> current = _firstElement;
            int length = 0;
            while (current != null)
            {
                length += 1;
                current = current.Next;
            }
            return length;
        }

        public LinkedList<T> Take(int lengthOfList)
        {
            LinkedList<T> takeList = new LinkedList<T>();
            Element<T> current = _firstElement;
            int count = 0;
            while (count < lengthOfList)
            {
                count += 1;
                takeList.Add(current.Data);
                current = current.Next;
            }
            takeList._lastElement.Next = current;
            return takeList;
        }

        public LinkedList<T> Skip(Element<T> element, int lengthOfList, int count)
        {
            LinkedList<T> resultList = new LinkedList<T>();
            while (count < lengthOfList)
            {
                count += 1;
                resultList.Add(element.Data);
                element = element.Next;
            }
            return resultList;
        }


        public void Print()
        {
            Element<T> current = _firstElement;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.ReadKey();
        }
    }
}
