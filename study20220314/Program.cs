using System;
using static System.Console;

namespace study20220314
{
    internal class Program
    {

        static int add(int a, int b)
        {
            return a+b;
        }

        static float add(float a, float b)
        {
            return a+b;
        }

        static void Main(string[] args)
        {
            int a,b;
            float c, d;


            Write("정수를 입력하시오 : ");
            string key = ReadLine();
            a = int.Parse(key); 
            key = ReadLine();
            b = int.Parse(key);
            Write("소수를 입력하시오 : ");
            key = ReadLine();
            c = float.Parse(key);
            key = ReadLine();
            d = float.Parse(key);
            
            int i = add(a, b);
            float f = add(c, d);
            
            WriteLine($"정수 : {i} , 소수 : {f}");
        }
    }
}
