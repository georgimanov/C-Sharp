using System;
using System.CodeDom;

namespace GenericClass
{
    internal class GenericClassClient
    {
        private static void Main()
        {
            GenericClass<int> genericClass = new GenericClass<int>(4);

            Console.WriteLine("Current list elements: {0}",genericClass);

            for (int i = 0; i < 4; i++)
            {
                genericClass.Add(i);
            }

            Console.WriteLine("List: {0}", genericClass);

            var findNumber = 3;
            var index = genericClass.FindFirstOrDefault(findNumber);
            Console.WriteLine("{0} is at {1} index", findNumber, index);

            var removeElement = 2;
            genericClass.RemoveElementByIndex(removeElement);
            Console.WriteLine("Remove element {0}", removeElement);
            Console.WriteLine("{0} -> withoud {1}",genericClass, removeElement);
            Console.WriteLine("Current size: {0}", genericClass.Size());

            var element = 9;
            var position = 3;
            genericClass.InsertElementAtIndex(position, element);
            Console.WriteLine("Insert {0} at position {1}", element, position);
            Console.WriteLine("Current size: {0}", genericClass.Size());
            Console.WriteLine("List: {0}", genericClass);

            Console.WriteLine("Max {0}", genericClass.Max());
            Console.WriteLine("Mix {0}", genericClass.Min());

            genericClass.Clear();
            Console.WriteLine("List cleared: {0}", genericClass);
        }
    }
}