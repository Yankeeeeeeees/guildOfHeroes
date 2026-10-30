using System;

class Program
{
    static void Main(string[] args)
    {
    //     Hero yaroslav = new Hero("Ярослав", 100);
    //     Hero anastasia = new Hero("Анастасия", 90);
    //     Hero artem = new Hero("Артём", 120);

    //     yaroslav.Health = 75;

    //     Console.WriteLine(">>> Герой 1 <<<");
    //     Console.WriteLine($"Имя: {yaroslav.Name}");
    //     Console.WriteLine($"Здоровье: {yaroslav.Health}");
    //     Console.WriteLine($"Уровень: {yaroslav.Level}");
    //     Console.WriteLine($"Опыт: {yaroslav.Experience}");

    //     Console.WriteLine();

    //     Console.WriteLine(">>> Герой 2 <<<");
    //     Console.WriteLine($"Имя: {anastasia.Name}");
    //     Console.WriteLine($"Здоровье: {anastasia.Health}");
    //     Console.WriteLine($"Уровень: {anastasia.Level}");
    //     Console.WriteLine($"Опыт: {anastasia.Experience}");

    //     Console.WriteLine();

    //     Console.WriteLine(">>> Герой 3 <<<");
    //     Console.WriteLine($"Имя: {artem.Name}");
    //     Console.WriteLine($"Здоровье: {artem.Health}");
    //     Console.WriteLine($"Уровень: {artem.Level}");
    //     Console.WriteLine($"Опыт: {artem.Experience}");


        Computer gaming = new Computer ("ATX", "RTX 5090", "i5 14600kf", 64, "800wt");
        Computer server = new Computer ("ATX", "RTX 6000", "Threadripper pro 9995wx", 256, "2000wt");
        Computer office = new Computer ("Mini ATX", "RX 580", "i5 10400f", 16, "550wt");

        Console.WriteLine ("Каталог компьютеров");

        Console.WriteLine("Компьютер 1: ");
        Console.WriteLine($"Корпус: {gaming.Case}");
        Console.WriteLine($"Видеокарта: {gaming.GPU}");
        Console.WriteLine($"Процессор: {gaming.CPU}");
        Console.WriteLine($"Количество ОЗУ: {gaming.RAM}");
        Console.WriteLine($"Блок питания: {gaming.BP}" );

        Console.WriteLine("");

        Console.WriteLine("Компьютер 2: ");
        Console.WriteLine($"Корпус: {server.Case}");
        Console.WriteLine($"Видеокарта: {server.GPU}");
        Console.WriteLine($"Процессор: {server.CPU}");
        Console.WriteLine($"Количество ОЗУ: {server.RAM}");
        Console.WriteLine($"Блок питания: {server.BP}" );

        Console.WriteLine("");

        Console.WriteLine("Компьютер 3: ");
        Console.WriteLine($"Корпус: {office.Case}");
        Console.WriteLine($"Видеокарта: {office.GPU}");
        Console.WriteLine($"Процессор: {office.CPU}");
        Console.WriteLine($"Количество ОЗУ: {office.RAM}");
        Console.WriteLine($"Блок питания: {office.BP}" );


    }
}