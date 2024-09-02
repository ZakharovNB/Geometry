using Geometry.Interfaces;

namespace Geometry.Shapes;

/// <summary>
/// Класс, представляющий треугольник 
/// </summary>
public class Triangle : ISquare
{
    /// <summary>
    /// Сторона A
    /// </summary>
    public double a { get; }

    /// <summary>
    /// Сторона B
    /// </summary>
    public double b  { get; }

    /// <summary>
    /// Сторона C
    /// </summary>
    public double c  { get; }
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="a">Длина стороны A</param>
    /// <param name="b">Длина стороны B</param>
    /// <param name="c">Длина стороны C</param>
    public Triangle(double a, double b, double c)
    {
        ValidateSides(a, b, c);

        (this.a, this.b, this.c) = (a, b, c);
    }
    
    /// <inheritdoc />
    public double CalculateSquare()
    {
        var p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    /// <summary>
    /// Проверить, является ли треугольник прямоугольным
    /// </summary>
    /// <returns>Флаг - треугольник прямоугольный</returns>
    public bool CheckIsRightTriangle()
    {
        var sides = new[] { a, b, c };

        Array.Sort(sides);

        return sides[2] == Math.Sqrt((Math.Pow(sides[0], 2)) + Math.Pow(sides[1], 2));
    }

    /// <summary>
    /// Провалидировать длины сторон треугольника
    /// </summary>
    /// <param name="a">Длина стороны A</param>
    /// <param name="b">Длина стороны B</param>
    /// <param name="c">Длина стороны C</param>
    private void ValidateSides(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new Exception("Сторона не может иметь отрицательное значение");
        }
        
        var isValid = a < b + c && b < a + c && c < a + b;

        if (!isValid)
        {
            throw new Exception("Не возможно построить треугольник с заданными сторонами A, B, C");
        }
    }
}