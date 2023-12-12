using System;

namespace LazySingleFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            SetValue(5);

            PrintValue();

            SetValue(8);

            PrintValue();

            SetValue(-10);

            PrintValue();

            SetValue(42);

            PrintValue();
        }

        public static void SetValue(float number)
        {
            SingletonFloat.Instance.Number = number;
        }

        public static void PrintValue()
        {
            Console.WriteLine(SingletonFloat.Instance.Number);
        }
    }
}
