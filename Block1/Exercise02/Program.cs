using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte: value from -128 to 127
            sbyte var1 = -115;
            sbyte var2 = 112;
            sbyte var3 = 94;
            sbyte var4 = -44;

            Console.WriteLine("sbyte  variables are: {0,20} {1,8} {2,8} {3,8}", var1, var2, var3, var4);

            // byte: value from 0 to 255
            byte var5 = 224;

            Console.WriteLine("byte   variables are: {0,20}", var5);

            // short: value from -32768 to 32767
            short var6 = -10000;
            short var7 = 20000;

            Console.WriteLine("short  variables are: {0,20} {1,8}", var6, var7);

            // ushort: value from 0 to 65535
            ushort var8 = 52130;
            ushort var9 = 1990;

            Console.WriteLine("ushort variables are: {0,20} {1,8}", var8, var9);

            // int: value from -2147483648 to 2147483648
            int var10 = -1000000;

            Console.WriteLine("int    variables are: {0,20}", var10);

            // uint: value from 0 4294967295
            uint var11 = 970700000;

            Console.WriteLine("uint   variables are: {0,20}", var11);

            // long: value from -9223372036854775808 to 9223372036854775807
            long var12 = 4825932;

            Console.WriteLine("long   variables are: {0,20}", var12);

            // ulong: value from 0 to 18446744073709551615
            ulong var13 = 123456789123456789;

            Console.WriteLine("ulong  variables are: {0,20}", var13);
        }
    }
}
