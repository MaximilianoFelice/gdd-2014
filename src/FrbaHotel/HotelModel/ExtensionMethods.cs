﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ExtensionMethods
{
    public static class Extnsions
    {
        public static Dictionary<TSource, TZipping> zip<TSource, TZipping>(this IEnumerable<TSource> anArray, IEnumerable<TZipping> anotherArray)
        {
            int i = 0;
            Dictionary<TSource, TZipping> zippedArray = new Dictionary<TSource, TZipping>();
            
            int size = anArray.Count(a => true);
            for (; i < size; i++)
            {
                zippedArray.Add(anArray.ElementAt(i), anotherArray.ElementAt(i));
            }

            return zippedArray;

        }

        public static void SetPropertyToLast<T1, T2>(this Stack<T1> aStack, String PropName, T2 value)
        {
            T1 lastObject = aStack.Peek();

            lastObject.GetType().GetProperty(PropName).SetValue(lastObject, value, null);
            
        }
    }

    public class Tuple<T1, T2>
    {
        public T1 First { get; private set; }
        public T2 Second { get; private set; }
        internal Tuple(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

    public static class Tuple
    {
        public static Tuple<T1, T2> New<T1, T2>(T1 first, T2 second)
        {
            var tuple = new Tuple<T1, T2>(first, second);
            return tuple;
        }
    }
}