using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vsrpp_3_julia
{
    public class Triangle : Figure
    {
        public string tip;
        public int a, b, c;
        public void per()
        { 
            perimeter = a + b + c;
            Type = "Периметр:";
            if(a==b && a==c && b==c)
            {
                Triangle_Type = "Равносторонний";
            }
            if (a == b && a!=c || a==c && a!=b || c==b && c!=a)
            {
                Triangle_Type = "Равнобедренный";
            }
            if(a*a+b*b==c*c || a*a+c*c==b*b || b*b+c*c==a*a)
            {
                Triangle_Type = "Прямоугольный";
            }
        }

        public void square()
        {
            int p = a + b + c;
            s = "Площадь: " + (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public Triangle(int a1, int b1, int c1, int x1, int y1, string tip1)
        {
            if ((a + b < c) || (a + c > b) || (b + c < a)) 
            { 
                a = 1;
                b = 1; 
                c = 0;
                tip = "Ошибка!!!";
            }
            a = a1;
            b = b1;
            c = c1;
            x = x1;
            y = y1;
            tip = tip1;
            per();
            square();
        }
    }
}