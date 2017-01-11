using System;

namespace P03.RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg)
            : base(msg)
        {
        }

        public InvalidRangeException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }

        public InvalidRangeException(string msg, T lowerLimit, T upperLimit)
            : this(msg)
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
        }

        public InvalidRangeException(string msg, Exception innerEx, T lowerLimit, T upperLimit)
            : this(msg, innerEx)
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
        }

        public T LowerLimit
        {
            get { return this.start; }
            private set { this.start = value; }
        }

        public T UpperLimit
        {
            get { return this.end; }
            private set { this.end = value; }
        }
    }
}
