using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamla
{
    public static class szamologep
    {
        public static int oszt(int a,int b)
        {
            int eredmeny= a / b;
            return eredmeny;
        }
        public static int szoroz(int a,int b)
        {
            int eredmeny= a * b;
            return eredmeny;
        }
        public static int osszead(int a, int b)
        {
            int eredmeny= a + b;
            return eredmeny;
        }
        public static int kivon(int a, int b)
        {
            int eredmeny = a - b;
            return eredmeny;
        }

    }

    public class Program
    {
        public static int a = 0;
        public static int b = 0;

        public static void szamolj()
        {
            Console.Write("Kérem az első számot: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Kérem a műveletet(*,/,+,-): ");
            char muvelet = char.Parse(Console.ReadLine());
            
            Console.Write("Kérem a második számot: ");
            b = int.Parse(Console.ReadLine());

            if (muvelet == '*')
            {
                Console.WriteLine("Az eredmény: "+szamologep.szoroz(a, b));
            }
            if (muvelet =='+')
            {
                Console.WriteLine("Az eredmény: "+szamologep.osszead(a, b));
            }
            if (muvelet == '-')
            {
                Console.WriteLine("Az eredmény: "+szamologep.kivon(a, b));
            }
            if (muvelet == '/')
            {
                Console.WriteLine("Az eredmény: "+szamologep.oszt(a, b));
            }


        }

        public static bool menjenmeg = true;

        static void Main(string[] args)
        {
            while (menjenmeg == true)
            {
                szamolj();
                Console.Write("Újra? (i/n): ");
                char menjen = char.Parse(Console.ReadLine());
                if (menjen =='i')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
