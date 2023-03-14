using FormaGeometrica;

Rectangle rectangle = new Rectangle(10.2, 26.3);
Triangle triangle = new Triangle(2.4, 3);

Console.WriteLine(rectangle.CalculateArea());
Console.WriteLine(triangle.CalculateArea(triangle.Height, triangle.Width));
