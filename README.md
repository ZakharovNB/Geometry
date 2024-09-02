# Пример использования библиотеки

```C#
// Если необходимо, чтобы новая фигура имела возможность вычисления
// площади, нужно чтобы её класс реализовывал интерфейс ISquare:
var shapesWithSquare = new ISquare[]
{
  new Circle(10),
  new Triangle(50, 50, 50)
};

// Вычисление площади фигуры без знания типа фигуры в compile-time:
foreach (var shape in shapesWithSquare)
{
  Console.WriteLine(shape.CalculateSquare());
}
        
// Проверка на то, является ли треугольник прямоугольным:
Console.WriteLine((shapesWithSquare[1] as Triangle)?.CheckIsRightTriangle());
```
