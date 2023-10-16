using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir valores máximos e mínimos de tipos de valor conhecidos
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.WriteLine();
            
            // Imprimir valores especiais a partir de float
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity / float.PositiveInfinity);

            Console.WriteLine();

            // Imprimir valores especiais a partir de double
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            Console.WriteLine();

            // Overflow e underflow em vários tipos inteiros
            short sMax = short.MaxValue, sMin = short.MinValue;
            int iMax = int.MaxValue, iMin = int.MinValue;
            Console.WriteLine((short) (sMax + 1));
            Console.WriteLine((short) (sMin - 1));
            Console.WriteLine((int) (iMax + 1));
            Console.WriteLine((int) (iMin - 1));

            Console.WriteLine();

            // Imprimir resultado de overflow em tipos reais
            double d1 = 2 * double.MaxValue, d2 = double.MaxValue + 1;
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine();

            // Imprimir resultado de underflow em tipos reais
            float f1, f2;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);
        }
    }
}
