using System;

namespace ConsoleApplication2
{
    internal static class RandomNumber
    {
        private static readonly Random Random = new Random();
        public static int Between(int a, int b) => Random.Next(a, b);
        public static int BasicTextDelay() => Random.Next(500, 1000);
    }
}