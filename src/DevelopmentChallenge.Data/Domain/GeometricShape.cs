namespace DevelopmentChallenge.Data.Domain
{
    public abstract class GeometricShape
    {
        public string ShapeType { get; protected set; }
        public decimal Perimeter { get; protected set; }
        public decimal Area { get; protected set; }
    }
}
