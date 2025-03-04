using System;

namespace Pag851_Es5;

public class Circle : Shape
{
    public Circle(int height)
    {
        int Height = height;
        int Width = height;
    }
    public override double CalculateSurface(int height, int width)
    {
        return Math.PI*height*height;
    }
    
}
