using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter14_Practice
{
    class GenericList<T> where T : IComparable
    {
        private const int DefaultElements = 100;
        private int NumberOfElement;
        private T[] Array;

        /* Constructors */
        public GenericList() : this(DefaultElements)
        {

        }

        public GenericList(int NumElements)
        {
            this.NumberOfElement = NumElements;
            this.Array = new T[this.NumberOfElement];
        }

        /* Methods */
        /* 1. Add an item with index */
        public void AddItem(int Index, T value)
        {
            if (Index < this.NumberOfElement)
            {
                if(this.Array[Index].CompareTo(value) == 0)
                {
                    this.Array[Index] = value;
                }
                else
                {
                    /* Through an exception */
                }
            }
            else
            {
                /* Through an exception */
            }
        }
        /* 2. Remove an item with index */
        public void RemoveItem(int Index)
        {

        }
        /* 3. Insert an item with index */

        /* 4. Clear the List */

        /* 5. Search an item by value */

        /* 6. Override the method ToString */
    }
}
