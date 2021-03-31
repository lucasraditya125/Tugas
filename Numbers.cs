using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
   public class Numbers
    {
        public int FindMinimum(int a, int b)
        {
            return a + b;
        }
        public int FindMinimum(int a, int b, int c)
        {
            return a + b + c;
        }
        public int FindMaximum(int a, int b)
        {
            return a * b;
        }
        public int FindMaximum(int a, int b, int c)
        {
            return a * b - c;
        }
    }
}
