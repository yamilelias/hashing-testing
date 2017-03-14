using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hash = "leepadg";

            // Start hashing
            var result = hashing(hash);
            Console.WriteLine($"The result is {result}");
        }

        public static long hashing(string hash)
        {
            // Initialize variables
            long h = 7;
            var letters = "acdegilmnoprstuw";
            var index = 0;
            long inc = 0;

            for(var k=0; k<hash.Length;k++)
            {
                inc = h * 37;
                index = letters.IndexOf(hash[k]);
                //index = hash.IndexOf(letters[k]);

                h = inc + index;
            }

            return h;
        }
    }
}
