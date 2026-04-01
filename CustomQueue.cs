using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace customq
{

    public class CustomQueue<T>
    {
        private T[] Qarray;
        private int count;

        public CustomQueue(int capacity)
        {
            if (capacity <= 0)
                throw new OverCapacityException("Capacity must be greater than zero");

            Qarray = new T[capacity];
            count = 0;
        }

        public int Count { get { return count; } }

        public void Enqueque(T item)
        {
            if (count == Qarray.Length)
            {
                Console.WriteLine("Queue is full. This item can not be enqueued");
            }
            Qarray[count] = item;
            count++;

        }
        public T Dequeque()
        {
            if(count == 0)
            {
                throw new OverCapacityException("Queue is Empty. This item can not be dequeued");
            }
            T item = Qarray[0];

            for (int i = 1; i < count; i++)
            {
                Qarray[i - 1] = Qarray[i];
            }
            Qarray[count - 1] = default;
            count --;
            return item;    

        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new OverCapacityException("Queue is Empty. Cannoy peek");
            }
            return Qarray[0];


        }

        public bool IsEmpty(T item)
        {
            if (Qarray == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

