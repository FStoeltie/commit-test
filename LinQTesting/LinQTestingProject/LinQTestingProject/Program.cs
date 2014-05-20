using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTestingProject
{
    class Program
    {

        internal delegate bool testThisDelegate(int n);

        private static void Main(string[] args)
        {
            int[] numbers = {1, 5, 4, 5, 1, 2, 0};
            //var first3Numbers = numbers.Take(3);


            foreach (var item in numbers.Take(4).Reverse())
            {
                Console.WriteLine("item:" + item);

            }
            string[] names =
            {
                "Burke", "Connor", "Frank",
                "Everett", "Albert", "George",
                "Harris", "David"
            };
            Func<string, bool> filter;
            filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();

            testDelegateMethod(testvar => testvar < 5);
            IEnumerable<string> query = names.Where(filter)
                .OrderBy(extract)
                .Select(project);
            foreach (var item in query)
            {
                Console.WriteLine("item:" + item);
            }

            while (true)
            {

            }

        }



        private static void testDelegateMethod ( testThisDelegate d )
        {
            System.Console.WriteLine(d(4));
        }
    }
}
