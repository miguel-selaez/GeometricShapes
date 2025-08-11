using System;

namespace DevelopmentChallenge.Data.Domain
{
    public class Square : GeometricShape
    {
        public Square(decimal side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("El lado del cuadrado tiene que ser mayor que 0");
            }

            ShapeType = nameof(Square);
            Perimeter = side * 4;
            Area = side * side;
        }
    }
}
