namespace GenericClass
{
    using System;
    using System.Linq;
    
    public class GenericClass<T>
    {
        private const int InitialSize = 16;
        private T[] data;
        private int indexer;

        public GenericClass()
            : this(InitialSize)
        {
            data = new T[InitialSize];
        }

        public GenericClass(int initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size must be bigger than 2");
            }

            data = new T[initialSize];
            indexer = 0;
        }

        public int Size()
        {
            return indexer;
        }

        public void Add(T element)
        {
            if (indexer == data.Count())
            {
                data = ResizeData();
            }

            data[indexer] = element;
            indexer++;
        }

        private T[] ResizeData()
        {
            var newData = new T[data.Count()*2];
            for (var i = 0; i < data.Count(); i++)
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

            for (var i = index; i < data.Count() - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[data.Count() - 1] = default(T);
            indexer--;
        }

        public void InsertElementAtIndex(int index, T element)
        {
            if (index < 0 || index > Size())
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            if (indexer + 1 == data.Count())
            {
                data = ResizeData();
            }

            for (var i = index; i <= Size(); i++)
            {
                data[i + 1] = data[i];
            }

            data[index] = element;

            indexer++;
        }

        public T GetElementAtIndex(int index)
        {
            return data[index];
        }

        public void Clear()
        {
            for (var i = 0; i < data.Count(); i++)
            {
                data[i] = default (T);
            }

            indexer = 0;
        }

        public int FindFirstOrDefault(T element)
        {
            for (var i = 0; i < data.Count(); i++)
            {
                if (data[i].Equals(element))
                {
                    return i;
                    break;
                }
            }

            return -1;
        }

        public T Max()
        {
            var max = data.OrderByDescending(x => x).FirstOrDefault();

            return max;
        }

        public T Min()
        {
            var min = data.OrderBy(x => x).FirstOrDefault();
            
            return min;
        }

        public override string ToString()
        {
            if (indexer == 0)
            {
                return "List is empty";
            }
            
            var printData = new T[Size()];
            for (var i = 0; i < Size(); i++)
            {
                printData[i] = data[i];
            }
            
            return String.Join(", ", printData);
        }
    }
}