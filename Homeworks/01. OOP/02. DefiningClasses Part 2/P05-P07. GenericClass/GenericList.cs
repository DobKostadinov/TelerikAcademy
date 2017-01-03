namespace P05_P07.GenericClass
{
    using System;

    public class GenericList<T> where T : IComparable
    {
        private int size;
        private T[] elements;
        private int index;

        public GenericList(int size)
        {
            this.Size = size;
            this.elements = new T[this.Size];
            this.index = 0;
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The size of the array cannot be negative number");
                }

                this.size = value;
            }
        }

        public void Add(T element)
        {
            this.elements[index] = element;
            this.index++;

            if (this.index == this.elements.Length)
            {
                this.elements = ResizeArray(this.elements);
            }
        }

        public T FindElementByIndex(int index)
        {
            this.IsIndexInRange(index);

            var element = this.elements[index];

            return element;
        }

        public void RemoveElement(int index)
        {
            this.IsIndexInRange(index);

            this.elements[index] = default(T);
        }

        public void ClearList()
        {
            this.elements = new T[this.size];
            this.index = 0;
        }

        public void InsertAtPosition(int index, T element)
        {
            this.IsIndexInRange(index);

            var tempIndex = index;
            var temp = new T[this.elements.Length - index];

            for (int i = 0; i < temp.Length; i++, tempIndex++)
            {
                temp[i] = this.elements[tempIndex];
            }

            this.elements[index] = element;

            if (this.elements.Length < (this.elements.Length + temp.Length))
            {
                this.elements = ResizeArray(this.elements);
            }

            for (int i = index + 1, counter = 0; i < this.elements.Length - i; i++, counter++)
            {
                this.elements[i] = temp[counter];
            }
        }

        public int Find(T element)
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public T Max()
        {
            T max = this.elements[0];

            for (int i = 1; i < this.elements.Length - 1; i++)
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }

            return max;
        }

        public T Min()
        {
            T min = this.elements[0];

            for (int i = 1; i < this.elements.Length - 1; i++)

                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }

            return min;
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements);
        }

        private static T[] ResizeArray(T[] elements)
        {
            T[] resizedArray = new T[elements.Length * 2];

            for (int i = 0; i < elements.Length; i++)
            {
                resizedArray[i] = elements[i];
            }

            return resizedArray;
        }

        private void IsIndexInRange(int index)
        {
            if (index < 0 || index > this.elements.Length)
            {
                throw new ArgumentOutOfRangeException("Index is out of range!");
            }
        }
    }
}
