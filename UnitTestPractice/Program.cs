using System;

namespace UnitTestPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public int Add(int x, int y)
        {
            return new Calculation().Add(x, y);
        }
    }
}
