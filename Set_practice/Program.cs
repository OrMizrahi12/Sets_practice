using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sets sets = new Sets(1,1,1,2,2,2,3,3,4,5,6,7);
            Sets sets1 = new Sets(56, 67, 78, 89);

            sets.Union(sets1);

            sets1.PrintThisSetArr();
            
        }
    }
}
