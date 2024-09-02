using Geometry.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests;

/// <summary>
/// Тестирование методов класса <see cref="Circle"/>
/// </summary>
[TestClass]
public class CircleTest
{
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Circle.ValidateRadius"/>
    /// Случай, когда окружность создается на основе корректного радиуса
    /// </summary>
    [TestMethod]
    public void ValidateRadius_CorrectRadius_SuccessfulCreation()
    {
        var circle = new Circle(10.5);
        
        Assert.IsNotNull(circle);
    }
    
    /// <summary>
    /// Тестирование метода <see cref="Geometry.Shapes.Circle.ValidateRadius"/>
    /// Случай, когда окружность создается на основе отрицательного радиуса
    /// </summary>
    [TestMethod]
    public void ValidateRadius_WrongRadius_ExceptionWhenCircleCreate() => 
        Assert.ThrowsException<Exception>(() => new Circle(-10.5), 
            "Радиус не может иметь отрицательное значение");
}