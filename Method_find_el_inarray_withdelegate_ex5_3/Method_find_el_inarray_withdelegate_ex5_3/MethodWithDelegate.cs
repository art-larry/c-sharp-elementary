using System;

namespace Method_find_el_inarray_withdelegate_ex5_3
{
    static class MethodWithDelegate
    {
        public static int FindElInArray(Object[] array, FindInArray find)
        {
            for(int i = 0; i < array.Length; ++i)
            {
                if (find(array[i]))
                    return i;
            }
            return -1;
        }
    }
}
