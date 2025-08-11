using System.Collections.Generic;
using DevelopmentChallenge.Data.Domain;
using DevelopmentChallenge.Data.Services;
using DevelopmentChallenge.Data.Services.JsonManager;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Services
{
    [TestFixture]
    public class SpanishPrinterServiceTest
    {
        private PrinterReportService _printerReport;

        [SetUp]
        public void SetUp()
        {
            _printerReport = new PrinterReportService(new SpanishManager());
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", _printerReport.Print(new List<GeometricShape>()));
        }
        
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var squares = new List<GeometricShape> {new Square(5)};

            var resume = _printerReport.Print(squares);

            Assert.AreEqual("<h1>Reporte de formas geométricas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>Total:<br/>1 Formas Perímetro 20 Área 25", resume);
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

            Assert.AreEqual("<h1>Reporte de formas geométricas</h1>3 Cuadrados | Área 35 | Perímetro 36 <br/>Total:<br/>3 Formas Perímetro 36 Área 35", resume);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
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
                "<h1>Reporte de formas geométricas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>1 Círculo | Área 7,07 | Perímetro 9,42 <br/>2 Triángulos Equilateros | Área 42 | Perímetro 39 <br/>1 Rectángulo | Área 5,5 | Perímetro 9,5 <br/>1 Trapecio | Área 32 | Perímetro 24,94 <br/>Total:<br/>7 Formas Perímetro 110,87 Área 115,57",
                resume);
        }
    }
}
