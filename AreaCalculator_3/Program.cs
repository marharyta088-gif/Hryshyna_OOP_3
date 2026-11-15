namespace AreaCalculator_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Площу якої фігури ви хочете отримати?");
            Console.WriteLine("1 - Квадрат");
            Console.WriteLine("2 - Круг");
            Console.WriteLine("3 - Прямокутник");
            Console.WriteLine("4 - Трикутник");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "1":
                case "квадрат":
                    Console.WriteLine("Введіть розмір сторони:");
                    float side = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Площа = {side * side}");
                    break;

                case "2":
                case "круг":
                    Console.WriteLine("Введіть розмір радіуса:");
                    float radius = float.Parse(Console.ReadLine());
                    float pi = 3.14159265f;
                    Console.WriteLine($"Площа = {pi * (radius * radius)}");
                    break;

                case "3":
                case "прямокутник":
                    Console.WriteLine("Введіть розмір першої сторони:");
                    float sideA = float.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть розмір другої сторони:");
                    float sideB = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Площа = {sideA * sideB}");
                    break;

                case "4":
                case "трикутник":
                    Console.WriteLine("Введіть розмір основи:");
                    float baseLength = float.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть розмір висоти:");
                    float height = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Площа = {(baseLength * height) / 2}");
                    break;

                default:
                    Console.WriteLine("Невідома фігура.");
                    break;
            }
        }
    }
}
