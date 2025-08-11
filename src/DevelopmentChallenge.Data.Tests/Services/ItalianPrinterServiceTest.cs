using System.Collections.Generic;
using DevelopmentChallenge.Data.Domain;
using DevelopmentChallenge.Data.Services;
using DevelopmentChallenge.Data.Services.JsonManager;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Services
{
    [TestFixture]
    public class PrinterReportServiceTest
    {
        private PrinterReportService _printerReport;

        [SetUp]
        public void SetUp()
        {
            _printerReport = new PrinterReportService(new ItalianManager());
        }

        [TestCase]
        public void TestResumenListaVaciaFormas()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>", _printerReport.Print(new List<GeometricShape>()));
        }
        
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var squares = new List<GeometricShape> {new Square(5)};

            var resume = _printerReport.Print(squares);

            Assert.AreEqual("<h1>Rapporto sulle forme geometriche</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>Totale:<br/>1 Forme Perimetro 20 Area 25", resume);
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

            Assert.AreEqual("<h1>Rapporto sulle forme geometriche</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>Totale:<br/>3 Forme Perimetro 36 Area 35", resume);
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
                "<h1>Rapporto sulle forme geometriche</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>2 Triangoli Equilateri | Area 42 | Perimetro 39 <br/>1 Rettangolo | Area 5,5 | Perimetro 9,5 <br/>1 Trapezio | Area 32 | Perimetro 24,94 <br/>Totale:<br/>7 Forme Perimetro 110,87 Area 115,57",
                resume);
        }
    }
}
