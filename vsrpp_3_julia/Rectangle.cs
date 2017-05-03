using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vsrpp_3_julia
{
    public class Rectangle : Figure
    {
        public int a, b;

        public void per() 
        { 
            perimeter = a * b; 
            Type = "Площадь:"; 
            Triangle_Type = "Прямоугольник"; 
        }
        public void square() 
        { 
            s = "Площадь:" + Convert.ToString(a * b); 
        }
        public Rectangle(int a1, int b1, int x1, int y1)
        {
            a = a1;
            b = b1;
            x = x1;
            y = y1;
            per();
            square();
        }
    }
}
