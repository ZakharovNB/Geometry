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
    public double Radius { get; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="radius">Радиус</param>
    public Circle(double radius)
    {
        ValidateRadius(radius);
        
        Radius = radius;
    }
    
    /// <inheritdoc />
    public double CalculateSquare() => Math.PI * Radius * Radius;

    /// <summary>
    /// Провалидировать длину радиуса
    /// </summary>
    /// <param name="radius">Длина радиуса</param>
    private void ValidateRadius(double radius)
    {
        if (radius < 0)
        {
            throw new Exception("Радиус не может иметь отрицательное значение");
        }
    }
}