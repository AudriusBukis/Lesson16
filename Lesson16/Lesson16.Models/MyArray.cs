using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Models
{
    public class MyArray<T>
    {
        private T[] TArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MyArray()
        {
            TArray = new T[Size];
        }

        public void AddElement (T elementToAdd)
        {
            if (CheckIfFull())
            {
                TArray = IncreaseListSize();
            }

            if (elementToAdd != null)
            {
                TArray[Index] = elementToAdd;
                Index++;
            }
            else
            {
                throw new ArgumentNullException(nameof(elementToAdd));
            }
        }
        private bool CheckIfFull()
        {
            if (Index == Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private T[] IncreaseListSize()
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            TArray.CopyTo(newArray, 0);
            return newArray; 
        }
        public void RemuveElement(T elementToRemuve)
        {
            int numIndex = Array.IndexOf(TArray, elementToRemuve);
            TArray = TArray.Where((val, idx) => idx != numIndex).ToArray();
           
        }
    }
}
