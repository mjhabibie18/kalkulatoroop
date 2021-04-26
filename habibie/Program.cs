using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habibie
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan a1 = new Pertambahan(1, 2);
            Console.WriteLine(a1.Proccess());
            Console.WriteLine(a1.A);
            Console.WriteLine(a1.B);
            Console.WriteLine("Ini merupakan hasil pertambahan : ");
            a1.Display();
            Pengurangan b1 = new Pengurangan(4, 1);
            Console.WriteLine(b1.Proccess());
            Console.WriteLine("Ini merupakan hasil pengurangan : ");
            b1.Display();
            Perkalian c1 = new Perkalian(3, 2);
            Console.WriteLine(c1.Proccess());
            Console.WriteLine(b1.C);
            Console.WriteLine(b1.D);
            Console.WriteLine("Ini merupakan hasil perkalian : ");
            c1.Display();
            Pembagian d1 = new Pembagian(10, 5);
            Console.WriteLine(d1.Proccess());
            Console.WriteLine("Ini merupakan hasil pembagian : ");
            d1.Display();
            Console.Read();

        }
        class Pertambahan : DemoAbstract
        {
            public int A { get; private set; }
            public int B { get; private set; }
            public Pertambahan(int a, int b)
            {
                A = a;
                B = b;
            }

            public override int Proccess()
            {
                return A + B;
            }
        }

        class Pengurangan : DemoAbstract
        {
            public int C { get; private set; }
            public int D { get; private set; }
            public Pengurangan(int c,int d)
            {
                C = c;
                D = d;
            }

            public override int Proccess()
            {
                return C - D;
            }
        }

        class Perkalian : DemoAbstract
        {
            public int E { get; private set; }
            public int F { get; private set; }
            public Perkalian(int e, int f)
            {
                E = e;
                F = f;
            }
            public override int Proccess()
            {
                return E * F;
            }
        }

        class Pembagian : DemoAbstract
        {
            public int G { get; private set; }
            public int H { get; private set; }
            public Pembagian(int g, int h)
            {
                G = g;
                H = h;
            }
            public override int Proccess()
            {
                return G / H;
            }
        }
    }
}
