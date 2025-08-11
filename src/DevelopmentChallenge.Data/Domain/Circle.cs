using System;

namespace DevelopmentChallenge.Data.Domain
{
    public class Circle : GeometricShape
    {
        public Circle(decimal diameter)
        {
            if (diameter <= 0)
                throw new ArgumentException("El diametro debe ser mayor a 0");

            ShapeType = nameof(Circle);
            Perimeter = (decimal)Math.PI * diameter;
            Area = (decimal)Math.PI * (diameter/2) * (diameter / 2);
        }
    }
}
