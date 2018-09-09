using System.Collections.Generic;
using System.Linq;

namespace Citrusbyte.Core
{
    public static class ArrayExtensions
    {
        public static object[] ToFlattened(this object[] array)
        {
            return GetInternalArrayFlattened(array);
        }

        private static object[] GetInternalArrayFlattened(object[] array)
        {
            var finalArray = new List<object>();
            if (array is object[])
            {
                foreach (object item in array)
                {
                    if (item is object[])
                        finalArray.AddRange(GetInternalArrayFlattened(item as object[]));
                    else
                        finalArray.Add(item);
                }
            }
            else
            {
                finalArray.Add(array.First());
            }

            return finalArray.ToArray();
        }
    }
}
