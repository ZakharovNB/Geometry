using Geometry.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests;

/// <summary>
/// Тестирование методов класса <see cref="Triangle"/>
/// </summary>
[TestClass]
public class TriangleTest
{
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.CalculateSquare"/>
    /// Случай, когда треугольник равносторонний
    /// </summary>
    [TestMethod]
    public void CalculateSquare_EquilateralTriangle_SuccessfulCalculation()
    {
        var triangle = new Triangle(50, 50, 50);
        var expectedSquare = 1082.5317547305483d;
        
        var actualSquare = triangle.CalculateSquare();
        
        Assert.AreEqual(expectedSquare, actualSquare);
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.CalculateSquare"/>
    /// Случай, когда треугольник прямоугольный
    /// </summary>
    [TestMethod]
    public void CalculateSquare_RightAngledTriangle_SuccessfulCalculation()
    {
        var triangle = new Triangle(5, 12, 13);
        var expectedSquare = 30d;
        
        var actualSquare = triangle.CalculateSquare();
        
        Assert.AreEqual(expectedSquare, actualSquare);
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.CheckIsRightTriangle"/>
    /// Случай, когда треугольник прямоугольный
    /// </summary>
    [TestMethod]
    public void CheckIsRightTriangle_CorrectTriangle_True()
    {
        var triangle = new Triangle(5, 12, 13);
        
        Assert.IsTrue(triangle.CheckIsRightTriangle());
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.CheckIsRightTriangle"/>
    /// Случай, когда треугольник не является прямоугольным
    /// </summary>
    [TestMethod]
    public void CheckIsRightTriangle_WrongTriangle_False()
    {
        var triangle = new Triangle(5, 5, 5);
        
        Assert.IsFalse(triangle.CheckIsRightTriangle());
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.ValidateSides"/>
    /// Граничный случай, когда сумма длин двух сторон равна длине третьей
    /// </summary>
    [TestMethod]
    public void ValidateSides_BoundaryCase_ExceptionWhenTriangleCreate()
    {
        double a = 10, b = 20, c = 30;

        Assert.ThrowsException<Exception>(() => new Triangle(a, b, c), 
            "Не возможно построить треугольник с заданными сторонами A, B, C");
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.ValidateSides"/>
    /// Случай, когда одна из сторон слишком длинная
    /// </summary>
    [TestMethod]
    public void ValidateSides_WrongSideTooLong_ExceptionWhenTriangleCreate()
    {
        double a = 10, b = 20, c = 60;

        Assert.ThrowsException<Exception>(() => new Triangle(a, b, c), 
            "Не возможно построить треугольник с заданными сторонами A, B, C");
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.ValidateSides"/>
    /// Случай, когда одна из сторон имеет отрицательное значение длины
    /// </summary>
    [TestMethod]
    public void ValidateSides_WrongSideHasNegativeLength_ExceptionWhenTriangleCreate()
    {
        double a = -12.3456, b = 65.4321, c = 64.44554339;

        Assert.ThrowsException<Exception>(() => new Triangle(a, b, c), 
            "Сторона не может иметь отрицательное значение");
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Triangle.ValidateSides"/>
    /// Случай, когда треугольник с заданными сторонами существует
    /// </summary>
    [TestMethod]
    public void ValidateSides_CorrectSides_SuccessfulCreation()
    {
        double a = 12.3456, b = 65.4321, c = 64.44554339;

        var triangle = new Triangle(a, b, c);
        
        Assert.IsNotNull(triangle);
    }
}