using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class MyInt
    {
        public int x = 0;

        //public static implicit operator int(MyInt v)
        //{
        //    throw new NotImplementedException();
        //}



        // Uncomment this conversion routine to resolve CS0029.

        public static implicit operator int(MyInt i)
        {
            return i.x;
        }

    }
}
