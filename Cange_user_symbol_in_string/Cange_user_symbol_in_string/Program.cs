using System;

namespace Cange_user_symbol_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string workString = null;
            char userSymbol = char.MinValue;
            workString = String.Join(" ", args);
            Console.WriteLine(workString);
            
            do
            {
                Console.Write("Enter one symbol:");
                string tmp = Console.ReadLine();
                if(Char.TryParse(tmp,out userSymbol))
                {
                    break;
                }
            }
            while (true);

            char[] chArray = workString.ToCharArray();
            for(int i = 0; i < chArray.Length; ++i)
            {
                if(chArray[i] == userSymbol)
                {
                    chArray[i] = Char.ToUpper(userSymbol);
                }
            }
            workString = new String(chArray);
            int c = workString.LastIndexOf(Char.ToUpper(userSymbol));
            workString = workString.Remove(c);

            Console.WriteLine(workString);
        }
    }
}
