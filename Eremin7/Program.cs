namespace Eremin7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            bool openDoor = false;
            bool isKey = false;
            int o1 = 1;
            int o2 = 2;
            int o3 = 3;
            int tr = 0;
            Console.WriteLine("Вы находитесь в комнате.");
            Console.WriteLine("Чтобы открыть эту дверь, вам надо найти три предмета, которые создадут вам секретный ящик.\n");
            while (isKey == false)
            {
                Console.WriteLine("Вы можете: 1.Открыть шкаф. 2.Заглянуть под стол. 3.Заглянуть в старые ящики. 4.Найти ключ. 5.Открыть секретный ящик");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    if (o1 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли предмет");
                        o1 = 0;
                        tr++;
                    }

                }
                if (choice == 2)
                {

                    if (o2 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли предмет");
                        o2 = 0;
                        tr++;
                    }
                }
                if (choice == 3)
                {

                    if (o3 == 0)
                    {
                        Console.WriteLine("Нeту");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли предмет");
                        o3 = 0;
                        tr++;
                    }
                }
                if (choice == 4)
                {
                    Console.WriteLine("Здесь пусто. Попробуй поискать в другом месте.");
                }
                if (choice == 5)
                {
                    if (tr == 3)
                    {
                        Console.WriteLine("Собрано 3 предмета.\n Получен секретный ящик, с ключом от двери...");
                        isKey = true;
                    }
                    else
                    {
                        Console.WriteLine("Найдите все предметы");
                    }
                }
            }

            Console.WriteLine("\nПоздравляю!!! Вы выбрались из тайной комнаты " + name);
            Console.ReadKey();
        }

    }
}    