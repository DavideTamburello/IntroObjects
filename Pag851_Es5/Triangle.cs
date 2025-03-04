using System;

namespace Pag851_Es5;

public class Triangle : Shape
{
    public override int CalculateSurface(int height, int width)
    {
        return height*width/2;
    }


}
