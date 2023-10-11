using System;
namespace lab1task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Конструктор без параметрів
            TCircle circle_0 = new TCircle();
            Console.WriteLine(circle_0);

            //Конструктор з параметрами
            TCircle circle_1 = new TCircle(3);
            Console.WriteLine(circle_1);

            //Конструктор копій
            TCircle circle_1_copy = new TCircle(circle_1);
            Console.WriteLine(circle_1_copy);

            //Перевірка через ввод користувача
            TCircle circle_2 = new TCircle();
            Console.WriteLine("Введіть радіус: ");
            circle_2.r = double.Parse(Console.ReadLine());

            //ToString() перевірка
            Console.WriteLine(circle_2);

            //Площа круга
            Console.WriteLine($"Площа = {circle_2.Square()}");

            //Площа сектора за кутом
            Console.WriteLine("Введіть кут до 360:");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine($"Площа сектора = {circle_2.SquareSec(angle)}");

            //Перевірка на рівність
            if (circle_1.IsEqual(circle_2))
            { Console.WriteLine("Кола рівні"); }
            else { Console.WriteLine("Кола нерівні"); }

            //Перевірка операторів
            Console.WriteLine(circle_1 + circle_2);
            Console.WriteLine(circle_1 - circle_2);
            Console.WriteLine(circle_2 * 2);
            Console.WriteLine(2 * circle_2);
            Console.WriteLine("---------------------------------------------------------");

            //Тест конуса 
            //Конструктор без параметрів
            TCone cone_0 = new TCone();
            Console.WriteLine(cone_0);

            //Конструктор з параметрами
            TCone cone_1 = new TCone(5, 3);
            Console.WriteLine(cone_1);

            //Конструктор копій
            TCone cone_1_copy = new TCone(cone_1);
            Console.WriteLine(cone_1_copy);

            //Перевірка через ввод користувача
            TCone cone_2 = new TCone();
            Console.WriteLine("Введіть висоту та радіус конуса через пробіл: ");

            string[] h_r = Console.ReadLine().Split(' ');
            cone_2.height = double.Parse(h_r[0]);
            cone_2.r = double.Parse(h_r[1]);
            
            //toString() перевірка
            Console.WriteLine(cone_2);

            //Площа конуса
            Console.WriteLine($"Площа = {cone_2.Square()}");

            //Площа сектора конуса (розгортки)
            Console.WriteLine($"Площа сектора = {cone_2.SquareSec()}");

            //Об’єм конуса
            Console.WriteLine($"Об’єм = {cone_2.Volume()}");

            //Перевірка на рівність
            if (cone_1.IsEqual(cone_2)) { Console.WriteLine("Конуси рівні"); }
            else { Console.WriteLine("Конуси нерівні"); }

            //Перевірка операторів
            Console.WriteLine(cone_1 + cone_2);
            Console.WriteLine(cone_1 - cone_2);
            Console.WriteLine(cone_2 * 2);
            Console.WriteLine(2 * cone_2);

        }
    }
}