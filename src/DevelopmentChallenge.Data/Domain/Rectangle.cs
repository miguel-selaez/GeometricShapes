using System;

namespace DevelopmentChallenge.Data.Domain
{
    public class Rectangle : GeometricShape
    {
        public Rectangle(decimal sideA, decimal sideB)
        {
            if (sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentException("Ambos lados del rectangulo deben ser mayores a 0");
            }

            ShapeType = nameof(Rectangle);
            Perimeter = sideA * 2 + sideB * 2;
            Area = sideA * sideB;
        }
    }
}
