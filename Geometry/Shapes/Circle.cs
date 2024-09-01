using Geometry.Interfaces;

namespace Geometry.Shapes;

/// <summary>
/// Класс, представляющий окружность
/// </summary>
public class Circle : ISquare
{
    /// <summary>
    /// Радиус окружности
    /// </summary>
    public double Radius { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="radius">Радиус</param>
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    /// <inheritdoc />
    public double CalculateSquare() => Math.PI * Radius * Radius;
}