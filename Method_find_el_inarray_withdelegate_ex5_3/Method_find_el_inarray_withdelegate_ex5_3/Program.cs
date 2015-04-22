using System;

namespace Method_find_el_inarray_withdelegate_ex5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "12", "231", "21", "-1" };
            int a = MethodWithDelegate.FindElInArray(arr, x => x == "-1");
            Console.Write(a);
        }
    }
}
