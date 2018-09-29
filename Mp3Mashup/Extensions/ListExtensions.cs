using System;
using System.Collections.Generic;

namespace Mp3Sum.Extensions
{
    public static class ListExtensions
    {
        public static void Dispose<T>(this List<T> list) where T : IDisposable
        {
            foreach (var obj in list)
            {
                obj.Dispose();
            }

            list.Clear();
        }
    }
}
