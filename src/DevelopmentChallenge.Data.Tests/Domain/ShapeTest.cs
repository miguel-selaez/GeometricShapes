using System;
using DevelopmentChallenge.Data.Domain;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Domain
{
    [TestFixture]
    public class ShapeTest
    {
        #region Circle Test
        
        [TestCase]
        public void TestCrearCiculoConDiametro4()
        {
            var shape = new Circle(4);
            Assert.AreEqual(12.57m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(12.57m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearCiculoConDiametro10()
        {
            var shape = new Circle(10);
            Assert.AreEqual(31.42m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(78.54m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearCiculoConDiametro15()
        {
            var shape = new Circle(15);
            Assert.AreEqual(47.12m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(176.71m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearCiculoConDiametro0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Circle(0);
                }
            );
        }

        [TestCase]
        public void TestCrearCiculoConDiametroNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Circle(-2);
                }
            );
        }

        #endregion
        
        #region Equilateral Triangle Test

        [TestCase]
        public void TestCrearTrianguloConLado5()
        {
            var shape = new EquilateralTriangle(5);
            Assert.AreEqual(15m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(10.83m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearTrianguloConLado8()
        {
            var shape = new EquilateralTriangle(8);
            Assert.AreEqual(24m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(27.71m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearTrianguloConLado12()
        {
            var shape = new EquilateralTriangle(12);
            Assert.AreEqual(36m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(62.35m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearTrianguloConLado0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new EquilateralTriangle(0);
                }
            );
        }

        [TestCase]
        public void TestCrearTrianguloConLadoNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new EquilateralTriangle(-2);
                }
            );
        }

        #endregion

        #region Square Test

        [TestCase]
        public void TestCrearCuadradoConLado3()
        {
            var shape = new Square(3);
            Assert.AreEqual(12m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(9m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearCuadradoConLado7()
        {
            var shape = new Square(7);
            Assert.AreEqual(28m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(49m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearCuadradoConLado12()
        {
            var shape = new Square(12);
            Assert.AreEqual(48m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(144m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearCuadradoConLado0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Square(0);
                }
            );
        }

        [TestCase]
        public void TestCrearCuadradoConLadoNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Square(-2);
                }
            );
        }

        #endregion

        #region Rectangle Test

        [TestCase]
        public void TestCrearRectanguloConBase4Altura6()
        {
            var shape = new Rectangle(4,6);
            Assert.AreEqual(20m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(24m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearRectanguloConBase10Altura5()
        {
            var shape = new Rectangle(10,5);
            Assert.AreEqual(30m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(50m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearRectanguloConBase8Altura12()
        {
            var shape = new Rectangle(8,12);
            Assert.AreEqual(40m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(96m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearRectanguloConBase0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Rectangle(0,2);
                }
            );
        }

        [TestCase]
        public void TestCrearRectanguloConAltura0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Rectangle(2,0);
                }
            );
        }

        [TestCase]
        public void TestCrearRectanguloConBaseNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Rectangle(-2,2);
                }
            );
        }

        [TestCase]
        public void TestCrearRectanguloConAlturaNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Rectangle(2,-2);
                }
            );
        }

        #endregion

        #region Trapezoid Test

        [TestCase]
        public void TestCrearTrapecioConBaseMenor10BaseMayor6Altura4()
        {
            var shape = new Trapezoid(10, 6, 4);
            Assert.AreEqual(24.94m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(32m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearTrapecioConBaseMenor20BaseMayor10Altura5()
        {
            var shape = new Trapezoid(20,10, 5);
            Assert.AreEqual(44.14m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(75m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearTrapecioConBaseMenor15BaseMayor9Altura7()
        {
            var shape = new Trapezoid(15,9,7);
            Assert.AreEqual(39.23m, Math.Round(shape.Perimeter, 2));
            Assert.AreEqual(84m, Math.Round(shape.Area, 2));
        }

        [TestCase]
        public void TestCrearTrapecioConBaseMenor0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Trapezoid(0, 2, 2);
                }
            );
        }

        [TestCase]
        public void TestCrearTrapecioConBaseMayor0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Trapezoid(2, 0, 2);
                }
            );
        }

        [TestCase]
        public void TestCrearTrapecioConAltura0Invalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Trapezoid(2, 2, 0);
                }
            );
        }


        [TestCase]
        public void TestCrearTrapecioConBaseMenorNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Trapezoid(-2, 2, 2);
                }
            );
        }

        [TestCase]
        public void TestCrearTrapecioConBaseMayorNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Trapezoid(2, -2, 2);
                }
            );
        }

        [TestCase]
        public void TestCrearTrapecioConAlturaNegativoInvalido()
        {
            Assert.Throws<ArgumentException>(() =>
                {
                    var shape = new Trapezoid(2, 2, -2);
                }
            );
        }

        #endregion
    }
}
