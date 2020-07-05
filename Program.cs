using System;

namespace Operators_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine( a + b);
            Console.WriteLine((float)a / (float)b); // need to cast conversion
            Console.WriteLine(a + b * c);
            Console.WriteLine( a > b ); // return bool 
            Console.WriteLine( a == b); // a != b.. 
            Console.WriteLine(!(a != b)); //
            Console.WriteLine( c > b && c > a);
            Console.WriteLine( c > b && c == a);

        }
    }
}
