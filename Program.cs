using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p1();
            //p2();
            //p3();
            //p4();
            //p5(); 
            //p6();
            //p7();
            //p8();
            //p9();
            //p10();
            //p11();
            //p12();
            //p13();
            //p14();
            //p15();
            //p16(); 
            //p17();
            //p18(); 
            //p19();
            //p20(); 
            //p21(); 
        }

        static void p1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((double)-b / a);
            Console.ReadKey();
        }

        private static int p2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("exemplul nu are solutii");
                return 0;
            }
            int d = b * b - 4 * a * c ;
            if (d <= 0)
            {
                Console.WriteLine("exemplul nu are solutii");
                return 0;
            }
            else if (d == 0)
                Console.WriteLine((double)-b / (2 * a));
            else
            {
                Console.WriteLine((double)(-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine((double)(-b + Math.Sqrt(d)) / (2 * a));
            }
            Console.ReadKey();
            return 0;
        }


        private static void p3()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"da, {n} se divide cu {k}");
            else
                Console.WriteLine($"nu, {n} nu se divide cu {k}");

            Console.ReadKey();
        }

        private static void p4()
        {
            int y = int.Parse(Console.ReadLine());

            if (y % 4 == 0)
                Console.WriteLine($"da, {y} este an bisect");
            else
                Console.WriteLine($"nu, {y} este an bisect");

            Console.ReadKey();
        }

        private static void p5() 
        {
            int nr = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i < k; i++)
                nr /= 10;
            nr %= 10;
            Console.WriteLine(nr);
        }

        private static void p6() 
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a > 0) && (b > 0) && (c > 0) && ((a + b > c) && (a + c > b) && (b + c > a)))
                    Console.WriteLine($"numerele {a}, {b}, {c} pot fi laturile unui triunghi");
            else
                    Console.WriteLine($"numerele {a}, {b}, {c} nu pot fi laturile unui triunghi");
        }

        private static void p7()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;

            Console.WriteLine($"dupa schimbare a={a} b={b}");

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"dupa schimbare a={a} b={b}");
        }

        private static void p8()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"dupa schimbare a={a} b={b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"dupa schimbare a={a} b={b}");
        }

        private static void p9()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(1);
            for ( int i = 2; i <= n/2; i++ )
            {
                if (n % i == 0)
                Console.Write($" {i}");
            }
            Console.Write($" {n} ");
        }

        private static void p10() 
        {
            int n = int.Parse(Console.ReadLine());
            int d = 0;
            
            for ( int i = 1;  i <= n; i++ )
            {
                if (n % i == 0)
                    d++;
            }
            if (d == 2)
                Console.WriteLine("numarul este prim");
            else
                Console.WriteLine("numarul nu este prim");

            Console.ReadKey();
        }

        private static int p11() 
        {
            int n = int.Parse(Console.ReadLine());
            int ogl = 0;

            while (n!=0)
            {
                ogl = ogl*10 + n % 10;
                n /= 10;
            }

            Console.WriteLine($"numarul invers este {ogl}");
            return 0;
        }

        private static void p12()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int nrd = 0;
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    nrd++;
            Console.WriteLine(nrd); 
            Console.ReadKey();
        }

        private static void p13()
        {
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = y1; i <= y2; i++)
                if (i % 4 == 0)
                    nr++;
            Console.WriteLine(nr);
        }

        private static void p14()
        {
            int n = int.Parse(Console.ReadLine());
            int pal = 0;
            int ncopy = n;
            while (n != 0)
            {
                pal = pal * 10 + n % 10;
                n /= 10;
            }
            if (pal == ncopy) 
                Console.WriteLine($"numarul este palindrom ");
            else
                Console.WriteLine($"numarul nu este palindrom ");
        }

        private static void p15()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if (b > c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine(+ a + " " + b + " " + c);
        }

        private static void p16()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;                                  
                a = a - b;
            }
            if (b > c)
            {
                b = b + c;
                c = b - c;                                 
                b = b - c;
            }
            if (c > d)
            {
                c = c + d;
                d = c - d;
                c = c - d;
            }
            if (d > e)
            {
                d = d + e;
                e = d - e;
                d = d - e;
            }
            if (a > d)
            {
                a = a + d;
                d = a - d;
                a = a - d;
            }
            if (b > c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            Console.WriteLine(+a + " " + b + " " + c + " " + d + " " + e);
        }

        private static void p17()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cmmmc = (a * b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            Console.WriteLine(a);
            Console.WriteLine(cmmmc/a);   
        }

        private static void p18()
        {
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p = 0;
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    n /= d;
                    p++;
                }
                if (p != 0)
                    Console.Write(+d + "^" + p + "*");
                d++;
                if (n > 1 && d * d > n)
                d = n;
            }
        }

        private static void p19()
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int y = n % 10;
            int cif = 1;
            n /= 10;
            while (n != 0)
            {
                if (cif == 1)
                    if (y != n % 10)
                    {
                        x = n % 10;
                        cif++;
                    }
                if (n % 10 != y && n % 10 != x)
                    cif++;
                n /= 10;
            }
            if (cif > 2)
                Console.WriteLine("este format din mai mult de 2 cifre");
            else
                Console.WriteLine("este format din 2 cifre, care se repeta");
        }

        static void p20()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string rezultat = Transformare(m, n);
            Console.WriteLine($"{m}/{n} = {rezultat}");
        }

        static string Transformare(int m, int n)
        {
            if (m == 0)
                return "0";

            bool verificare = (m < 0) ^ (n < 0);
            m = Math.Abs(m);
            n = Math.Abs(n);

            int parteIntreaga = m / n;
            int remainder = m % n;
            List<int> remainders = new List<int>();
            List<int> digits = new List<int>();

            while (remainder != 0 && !remainders.Contains(remainder))
            {
                remainders.Add(remainder);
                remainder *= 10;
                digits.Add(remainder / n);
                remainder %= n;
            }

            string rezultat = $"{parteIntreaga}.{string.Join("", digits)}";
            if (remainder != 0)
            {
                int index = remainders.IndexOf(remainder);
                rezultat = $"{parteIntreaga}.{string.Join("", digits.GetRange(0, index))}({string.Join("", digits.GetRange(index, digits.Count - index))})";
            }

            return verificare ? $"-{rezultat}" : rezultat;
            // ajutor de la chatGPT :))
        }

        private static void p21()
        {
            Console.WriteLine("Ghiceste numarul cuprins intre 1-1024");
            Random n = new Random();
            int random = n.Next(1, 1024);
            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti un numar: ");
            while (nr != random)
            { 
                if (nr < random)
                    Console.WriteLine("Numarul este prea mic, introduceti alt numar: ");
                else 
                    Console.WriteLine("Numarul este prea mare, introduceti alt numar: ");
                                nr = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Felicitari!");
        }

    }
}
