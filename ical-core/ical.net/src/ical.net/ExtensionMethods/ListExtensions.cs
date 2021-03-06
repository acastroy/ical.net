﻿using System.Collections.Generic;

namespace Ical.Net.ExtensionMethods
{
    public static class ListExtensions
    {
        public static void AddRange<T>(this IList<T> list, IEnumerable<T> values)
        {
            if (values != null)
            {
                foreach (var item in values)
                {
                    list.Add(item);
                }
            }
        }
    }
}