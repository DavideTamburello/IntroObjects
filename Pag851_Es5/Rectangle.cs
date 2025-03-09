using System;

namespace Pag851_Es5;

public class Rectangle : Shape
{
    public override double CalculateSurface(int height, int width)
    {
        return height*width;
    }
}
