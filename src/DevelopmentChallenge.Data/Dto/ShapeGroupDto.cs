namespace DevelopmentChallenge.Data
{
    public class ShapeGroupDto
    {
        public string ShapeType { get; }
        public decimal PerimeterSum { get; }
        public decimal AreaSum { get; }
        public int ShapeCount { get; }

        public ShapeGroupDto(string shapeType, decimal perimeterSum, decimal areaSum, int shapeCount)
        {
            ShapeType = shapeType;
            PerimeterSum = perimeterSum;
            AreaSum = areaSum;
            ShapeCount = shapeCount;
        }
    }

}