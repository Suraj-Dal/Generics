using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class Generic<T> where T : IComparable
    {
        public T[] value;
        public Generic(T[] value)
        {
            this.value = value; 
        }
        public static T[] sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public static T findMaximum(params T[] value ) 
        {
            var sorted_values = sort(value);
            return sorted_values[value.Length - 1];
        }
        public T showMax()
        {
            var Result = Generic<T>.findMaximum(this.value);
            return Result;
        }
    }   
}
