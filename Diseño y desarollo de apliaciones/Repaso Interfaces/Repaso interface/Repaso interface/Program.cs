using Repaso_interface;

Console.WriteLine("1. Triangulo \n 2. Rectangulo");
if (Console.ReadLine() == "1")
{
    Triangulo triangulo = new Triangulo();
    Console.WriteLine("Ingrese la base del triangulo");
    triangulo.Base = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura del triangulo");
    triangulo.altura = float.Parse(Console.ReadLine());
    Console.WriteLine($"El area del triangulo es: {triangulo.CalcularArea(triangulo.altura, triangulo.Base)}");
    Console.WriteLine($"El perimetro del triangulo es: {triangulo.CalcularPerimetro(triangulo.altura, triangulo.Base)}");
}
else
{
    Rectangulo rectangulo = new Rectangulo();
    Console.WriteLine("Ingrese la base del rectangulo");
    rectangulo.Base = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura del rectangulo");
    rectangulo.altura = float.Parse(Console.ReadLine());
    Console.WriteLine($"El area del rectangulo es: {rectangulo.CalcularArea(rectangulo.altura, rectangulo.Base)}");
    Console.WriteLine($"El perimetro del rectangulo es: {rectangulo.CalcularPerimetro(rectangulo.altura, rectangulo.Base)}");
}