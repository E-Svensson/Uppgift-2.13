using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter dina anställda?");
            Console.Write("Anställd 1: "); string str1 = Console.ReadLine();
            Console.Write("Anställd 2: "); string str2 = Console.ReadLine();
            Console.Write("Anställd 3: "); string str3 = Console.ReadLine();
            Console.WriteLine("Bestäm nu dina anställdas löner i kronor.");
            Console.Write(str1 + ": "); string str1Lön = Console.ReadLine();
            Console.Write(str2 + ": "); string str2Lön = Console.ReadLine();
            Console.Write(str3 + ": "); string str3Lön = Console.ReadLine();

            int int1Lön = int.Parse(str1Lön);
            int int2Lön = int.Parse(str2Lön);
            int int3Lön = int.Parse(str3Lön);

            int sum = int1Lön + int2Lön + int3Lön;

            Console.WriteLine("Deras löner summerade blir då: " + sum + "kr");
        }
    }
}
