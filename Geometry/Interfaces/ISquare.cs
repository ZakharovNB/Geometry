namespace Geometry.Interfaces;

/// <summary>
/// Интерфейс, для реализации расчета площади геометрической фигуры
/// </summary>
public interface ISquare
{
    /// <summary>
    /// Рассчитать площадь геометрической фигуры
    /// </summary>
    /// <returns>Площадь геометрической фигуры</returns>
    public double CalculateSquare();
}