using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //string someString = "interpolation";
            //Console.WriteLine(someString.Length);
            //string newString = someString.Substring(5, 8);
            //Console.WriteLine(newString);
            DisplayLOGIT();
        }
        public static void DisplayLOGIT()
        {
            string LOGITfull = "LOGITpe20";
            string LOGITsub = LOGITfull.Substring(0, 5);
            string LOGITsubpe = LOGITfull.Substring(5, 2);
            string LOGITsub20 = LOGITfull.Substring(7, 2);
            Console.WriteLine(LOGITsub);
            Console.WriteLine(LOGITsubpe);
            Console.WriteLine(LOGITsub20);
        }
    }
}
