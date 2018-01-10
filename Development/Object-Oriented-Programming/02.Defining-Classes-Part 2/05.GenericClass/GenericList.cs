namespace _05.GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    /// Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    /// Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
    /// clearing the list, finding element by its value and ToString().
    /// Check all input parameters to avoid accessing elements at invalid positions.
    public class GenericList<T>
        where T : IComparable
    {
        private const int DefaultSize = 16;

        private const int InitialCount = 0;

        private T[] elements;

        private int initilSize;

        public GenericList()
            : this(DefaultSize)
        {
        }

        public GenericList(int size)
        {
            this.elements = new T[size];
            this.Count = InitialCount;
            this.initilSize = size;
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                this.Validate(index);
                return this.elements[index];
            }

            set
            {
                this.Validate(index);
                this.elements[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Count >= this.Capacity)
            {
                this.Increase();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException($"Index must be betwen zero and count ot the elements");
            }

            for (int i = index; i < this.Count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.Count--;
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException($"Index must be betwen zero and count ot the elements");
            }

            if (this.Count >= this.Capacity)
            {
                this.Increase();
            }

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.elements[i + 1] = this.elements[i];
            }

            this.Count++;
            this[index] = element;
        }

        public int IndexOf(T element)
        {
            var indexOf = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (element.CompareTo(this.elements[i]) == 0)
                {
                    indexOf = i;
                    break;
                }
            }

            return indexOf;
        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("Empty list");
            }

            T min = this.elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (min.CompareTo(this.elements[i]) > 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("Empty list");
            }

            T max = this.elements[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (max.CompareTo(this.elements[i]) < 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int elementIndex = 0; elementIndex < this.Count; elementIndex++)
            {
                sb.Append(this.elements[elementIndex]);
                if (elementIndex < this.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        public void Clear()
        {
            var newEleents = new T[this.initilSize];
            this.elements = newEleents;
            this.Count = InitialCount;
        }

        private void Validate(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException($"Index must be betwen zero and count ot the elements");
            }
        }

        private void Increase()
        {
            var newElements = new T[this.Capacity * 2];
            Array.Copy(this.elements, newElements, this.Capacity);
            this.elements = newElements;
        }
    }
}
