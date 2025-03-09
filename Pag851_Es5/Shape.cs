using System;

namespace Pag851_Es5;

public abstract class Shape
{
    int Width { get; set; }
    int Height { get; set; }
    public abstract double CalculateSurface(int height, int width);
}
