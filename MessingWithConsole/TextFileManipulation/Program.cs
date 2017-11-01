using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            S st = new S();
            st.X = 5;
            Console.WriteLine(st.X);
           
            Console.ReadKey();
        }

        struct S
        {
            int _x;

            public int X
            {
                get { return _x; }
                set
                {
                    if(value < 10)
                    {
                        _x = value;
                    }
                }
            }
        };
    }
}
