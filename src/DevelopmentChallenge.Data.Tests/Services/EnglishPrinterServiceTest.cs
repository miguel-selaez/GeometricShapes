using System.Collections.Generic;
using DevelopmentChallenge.Data.Domain;
using DevelopmentChallenge.Data.Services;
using DevelopmentChallenge.Data.Services.JsonManager;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Services
{
    [TestFixture]
    public class EnglishPrinterServiceTest
    {
        private PrinterReportService _printerReport;

        [SetUp]
        public void SetUp()
        {
            _printerReport = new PrinterReportService(new EnglishManager());
        }
        
        [TestCase]
        public void TestResumenListaVacia()
        {
            _printerReport = new PrinterReportService(new EnglishManager());
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", _printerReport.Print(new List<GeometricShape>()));
        }
        
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var squares = new List<GeometricShape> {new Square(5)};

            var resume = _printerReport.Print(squares);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>Total:<br/>1 Shapes Perimeter 20 Area 25", resume);
        }
        
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var squares = new List<GeometricShape>
            {
                new Square( 5),
                new Square( 1),
                new Square( 3)
            };

            var resume = _printerReport.Print(squares);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>Total:<br/>3 Shapes Perimeter 36 Area 35", resume);
        }
        
        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var shapes = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Rectangle( 2,2.75m),
                new Trapezoid(10,6,4)
            };

            var resume = _printerReport.Print(shapes);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>1 Circle | Area 7,07 | Perimeter 9,42 <br/>2 Equilateral Triangles | Area 42 | Perimeter 39 <br/>1 Rectangle | Area 5,5 | Perimeter 9,5 <br/>1 Trapezoid | Area 32 | Perimeter 24,94 <br/>Total:<br/>7 Shapes Perimeter 110,87 Area 115,57",
                resume);
        }
    }
}
