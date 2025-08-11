using System;

namespace DevelopmentChallenge.Data.Domain
{
    public class EquilateralTriangle : GeometricShape
    {
        public EquilateralTriangle(decimal side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("El lado del triangulo tiene que ser mayor que 0");
            }

            ShapeType = nameof(EquilateralTriangle);
            Perimeter = side * 3;
            Area = ((decimal)Math.Sqrt(3) / 4) * side * side;
        }
    }
}
