using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class Generic<T> where T : IComparable
    {
        public T first, second, third;
        public Generic(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third; 
        }
        public static T findMaximum(T first, T second, T third) 
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            else
                return third;
        }
        public T showMax()
        {
            T Result = Generic<T>.findMaximum(this.first, this.second, this.third);
            return Result;
        }
    }   
}
