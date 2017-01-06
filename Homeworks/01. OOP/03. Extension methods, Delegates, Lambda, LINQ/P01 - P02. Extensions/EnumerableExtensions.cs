namespace P01___P02.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableExtensions
    {
        public static T NewImplSum<T>(this IEnumerable<T> enumerable)
        {
            T sum = default(T);

            foreach (T item in enumerable)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T NewImplProduct<T>(this IEnumerable<T> enumerable)
        {
            T product = default(T) + (dynamic)1;

            foreach (var item in enumerable)
            {
                product *= (dynamic)item;
            }

            return product;
        }


        public static T NewImplMin<T>(this IEnumerable<T> enumerable)
        {
            T min = (dynamic)enumerable.ElementAt(0);

            foreach (var item in enumerable)
            {
                if (min > (dynamic)item)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T NewImplMax<T>(this IEnumerable<T> enumerable)
        {
            T max = (dynamic)enumerable.ElementAt(0);

            foreach (var item in enumerable)
            {
                if (max < (dynamic)item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T NewImplAverage<T>(this IEnumerable<T> enumarable)
        {
            T sum = default(T);
            T avg = default(T);
            int counter = 0;

            foreach (var item in enumarable)
            {
                sum += (dynamic)item;
                counter++;
            }

            avg = (dynamic)sum / counter;

            return avg;
        }
    }
}
