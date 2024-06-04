using LearningInterfaces.Concretes;

#region Rectangle

Rectangle rectangle = new();

rectangle.SideA = 10;
rectangle.SideB = 10;

decimal rectangleArea = rectangle.CalculateArea();

// Console.WriteLine(rectangleArea);

#endregion

#region Circle
Circle circle = new();
circle.Radius = 10;

decimal circleArea = circle.CalculateArea();
decimal circlePerimeter = circle.CalculatePerimeter();

Console.WriteLine($"Area: {circleArea}");
Console.WriteLine($"Permiter: {circlePerimeter}");

#endregion