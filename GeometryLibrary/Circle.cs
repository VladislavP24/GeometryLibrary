namespace GeometryLibrary;

/// <summary>
/// Класс круга
/// </summary>
public class Circle : IShape
{
    public Circle(double radius)
        => Radius = radius;

    public double Radius { get; set; }

    /// <summary>
    /// Расчёт площади
    /// </summary>
    public double CalculateArea()
        => Math.PI * Math.Pow(Radius, 2);
}
