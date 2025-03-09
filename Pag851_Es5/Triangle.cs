using System;
using static Program;

namespace Pag851_Es5;

public class Triangle : Shape
{
    public override double CalculateSurface(int height, int width)
    {
        return height*width/2;
    }
}
