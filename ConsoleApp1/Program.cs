using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Plus(in int a)
        {
            //아래와 같이 값에 대한 수정은 오류발생
            //Uncomment the following line to see error CS8331
            //a = 19;

            Console.WriteLine(a + 121);
        }
        static void Main(string[] args)
        {
            int nA = 777;

            Plus(nA);
        }
    }
}