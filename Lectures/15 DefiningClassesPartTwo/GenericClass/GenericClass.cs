using System.Data.Common;

namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericClass<T>
    {
        private const int InitialSize = 16;
        private T[] data;
        private int indexer;

        public GenericClass() 
            : this(InitialSize)
        {
            this.data = new T[InitialSize];
        }

        public GenericClass(int initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size must be bigger than 2");
            }

            this.data = new T[initialSize];
            this.indexer = 0;
        }

        public int Size()
        {
            return this.indexer;
        }

        public void Add(T element)
        {
            if (this.indexer == this.data.Count())
            {
                this.data = ResizeData();
            }
            
            this.data[indexer] = element;
            this.indexer++;
        }

        private T[] ResizeData()
        {
            var newData = new T[this.data.Count() * 2];
            for (int i = 0; i < this.data.Count(); i++)
            {
                newData[i] = GetElementAtIndex(i);
            }
            return newData;
        }

        public void RemoveElementByIndex(int index)
        {
            if (index < 0 || index > Size())
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            for (int i = index; i < this.data.Count() - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.data[this.data.Count() - 1] = default(T);
            this.indexer--;
        }

        public void InsertElementAtIndex(int index, T element)
        {
            if (index < 0 || index > Size())
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            if (this.indexer + 1 == this.data.Count())
            {
                this.data = ResizeData();
            }

            for (int i = index; i <= this.Size(); i++)
            {
                this.data[i + 1] = this.data[i];
            }

            this.data[index] = element;

            indexer++;
        }

        public T GetElementAtIndex(int index)
        {
            return this.data[index];
        }

        public void Clear()
        {
            for (int i = 0; i < this.data.Count(); i++)
            {
                this.data[i] = default (T);
            }

            this.indexer = 0;
        }

        public int FindFirstOrDefault(T element)
        {
            for (int i = 0; i < this.data.Count(); i++)
            {
                if (this.data[i].Equals(element))
                {
                    return i;
                    break;
                }
            }

            return -1;
        }

        public T Max()
        {
            var max = this.data.OrderByDescending(x => x).FirstOrDefault();
            return max;
        }

        public T Min()
        {
            var min = this.data.OrderBy(x => x).FirstOrDefault();
            return min;
        }

        public override string ToString()
        {
            if (this.indexer == 0)
            {
                return "List is empty";
            }
            var printData = new T[Size()];
            for (int i = 0; i < Size(); i++)
            {
                printData[i] = this.data[i];
            }
            return String.Join(", ", printData);
        }
    }
}
