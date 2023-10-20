namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Квадрат\n" +
                    "2. Прямоугольник\n" +
                    "3. Круг\n" +
                    "4. Треугольник\n" +
                    "5. Пирамида");

                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.Write("Введите сторону квадрата: "); int side = Convert.ToInt32(Console.ReadLine());
                        Square square = new Square(side);
                        Console.Clear();

                        square.Out();

                        Console.Write("\nНажмите ENTER чтобы продолжить");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.Write("Введите ширину прямоугольника: "); int width = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите высоту прямоугольника: "); int height = Convert.ToInt32(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(width, height);
                        Console.Clear();

                        rectangle.Out();

                        Console.Write("\nНажмите ENTER чтобы продолжить");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.Write("Введите радиус круга: "); int radius = Convert.ToInt32(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        Console.Clear();

                        circle.Out();

                        Console.Write("\nНажмите ENTER чтобы продолжить");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.Write("Введите сторону треугольника A: "); int sideA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите сторону треугольника B: "); int sideB = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите сторону треугольника C: "); int sideC = Convert.ToInt32(Console.ReadLine());
                        Triangle triangle = new Triangle(sideA, sideB, sideC);
                        Console.Clear();

                        if (triangle.Type() != "Не существует")
                        {
                            triangle.Out();
                        } 

                        else
                        {
                            Console.WriteLine("Такого треугольника не существует");
                        }

                        Console.Write("\nНажмите ENTER чтобы продолжить");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        Console.Write("Введите длину стороны основания: "); double sideP = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите высоту пирамиды: "); double heightP = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите количество сторон пирамиды: "); double amountSides = Convert.ToDouble(Console.ReadLine());
                        Pyramid pyramid = new Pyramid(sideP, heightP, amountSides);
                        Console.Clear();

                        pyramid.Out();

                        Console.Write("\nНажмите ENTER чтобы продолжить");
                        Console.ReadLine();

                        break;
                }

            }

        }
    }
}