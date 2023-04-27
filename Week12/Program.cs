// See https://aka.ms/new-console-template for more information

using Week12;

Shape shape = new Circle(5);
//Console.WriteLine(Shape.GetArea());

Shape[] Shape =
{
    shape,
    new Rectangle(8,7),
    new Square(5),
    new Circle(10),
new Rectangle(10, 2)
};

for (int i = 0; i < Shape.Length; i++)
{
    Console.WriteLine(Shape[i].GetArea());


}