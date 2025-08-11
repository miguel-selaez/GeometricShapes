using System;

namespace DevelopmentChallenge.Data.Domain
{
    public class Trapezoid : GeometricShape
    {
        public Trapezoid(decimal baseMinior, decimal baseMajor, decimal height)
        {
            if (baseMinior <= 0 || baseMajor <= 0 || height <= 0)
            {
                throw new ArgumentException("Todos los lados del trapecio deben ser mayores a 0");
            }

            ShapeType = nameof(Trapezoid);

            var leg = (baseMajor - baseMinior) / 2;
            var side = Math.Sqrt(Math.Pow((double)height, 2) + (double)(leg * leg));
            Perimeter = baseMinior + baseMajor + (decimal)(2 * side);
            Area = ((baseMajor + baseMinior) / 2) * height;
        }
    }
}
