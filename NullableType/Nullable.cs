using System;

namespace NullableType
{
    class Nullable
    {
        static void Main(string[] args)
        {
            // defining Nullable type
            Nullable<int> n = null;

            // using the method
            // output will be 0 as default
            // value of null is 0
            Console.WriteLine(n.GetValueOrDefault());

            // defining Nullable type
            int? n1 = null;

            // using the method
            // output will be 0 as default
            // value of null is 0
            Console.WriteLine(n1.GetValueOrDefault());


            // using Nullable type syntax
            // to define non-nullable
            int? n2 = 47;

            // using the method
            Console.WriteLine(n2.GetValueOrDefault());

            // using Nullable type syntax
            // to define non-nullable
            Nullable<int> n3 = 457;

            // using the method
            Console.WriteLine(n3.GetValueOrDefault());

        }

    

    }
}
