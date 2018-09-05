using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class Allocate
    {
        static void Main(string[] args)
        {
            int[] n = new int[21];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = i * 5;
                Console.Write(n[i] + " ");
            }
        }
    }
}
