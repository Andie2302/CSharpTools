using System.Numerics;

namespace CSharpTools;

public static class Tools
{
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }

    public static class Numbers
    {
        public static bool IsZero(int number) => number == 0;
        public static bool IsZero(uint number) => number == 0;
        public static bool IsZero(long number) => number == 0;
        public static bool IsZero(ulong number) => number == 0;
        public static bool IsZero(BigInteger number) => number.IsZero;

        public static bool IsEven(int number) => IsZero(number & 1);
        public static bool IsEven(uint number) => IsZero(number & 1);
        public static bool IsEven(long number) => IsZero(number & 1);
        public static bool IsEven(ulong number) => IsZero(number & 1);
        public static bool IsEven(BigInteger number) => number.IsEven;


        public static int GreatestCommonDivisor(int a, int b) => (int)GreatestCommonDivisor((long)a, (long)b);
        public static uint GreatestCommonDivisor(uint a, uint b) => (uint)GreatestCommonDivisor((ulong)a, b);
        public static long GreatestCommonDivisor(long a, long b) => (long)GreatestCommonDivisor((ulong)Math.Abs(a), (ulong)Math.Abs(b));

        public static ulong GreatestCommonDivisor(ulong a, ulong b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        public static BigInteger GreatestCommonDivisor(BigInteger a, BigInteger b) => BigInteger.GreatestCommonDivisor(a, b);
        public static int LeastCommonMultiple(int a, int b) => (int)LeastCommonMultiple((long)a, (long)b);
        public static uint LeastCommonMultiple(uint a, uint b) => (uint)LeastCommonMultiple((ulong)a, (ulong)b);
        public static long LeastCommonMultiple(long a, long b) => (long)LeastCommonMultiple((ulong)Math.Abs(a), (ulong)Math.Abs(b));
        public static ulong LeastCommonMultiple(ulong a, ulong b) => a / GreatestCommonDivisor(a, b) * b;
        public static BigInteger LeastCommonMultiple(BigInteger a, BigInteger b) => a * b / GreatestCommonDivisor(a, b);
    }
}