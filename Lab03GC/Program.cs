using System;
using System.Diagnostics;
using System.Threading;

class LargeObject
{
    private int[] data;
    private int id;
    private static int lastId = 0;
    public LargeObject(int size)
    {
        // Ініціалізуємо великий масив (розміру size)
        data = new int[size];
        id = ++lastId;//ID об'єкта (порядковий номер)
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Object created: {id}");
    }

    // Деструктор (finalizer) - буде спрацьовувати при вилученні об'єкта збіриником сміття
    ~LargeObject()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Destructor called for object:# {id}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створили об'єкт для вимірювання часу
        Stopwatch stopwatch = new Stopwatch();

        // Змінні для відстеження використання пам'яті 
        long memoryBefore, memoryAfter;

        // Початкові заміри пам'яті
        memoryBefore = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory before creation: {memoryBefore / 1024} KB");

        // Кількість створюваних об'єктів
        const int numObjects = 100000; // 1000
        stopwatch.Start(); // починає вимірювати час

        for (int i = 0; i < numObjects; i++)
        {
            var obj = new LargeObject(100000);//Створення великого об'єкта

            // Зануляємо посилання, щоб об'єкт став доступним для збору сміття
            if (i % 100 == 0) obj = null;
            //Примусовий виклик збирача сміття кожні 100  ітерацій
            if (i % 100 == 0)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        stopwatch.Stop();//Зупинили вимірювання часу

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Object creation completed in: {stopwatch.ElapsedMilliseconds} ms");
        // Кількість зборів для кожного покоління
        Console.WriteLine($"Gen 0 collections: {GC.CollectionCount(0)}");
        Console.WriteLine($"Gen 1 collections: {GC.CollectionCount(1)}");
        Console.WriteLine($"Gen 2 collections: {GC.CollectionCount(2)}");
        Console.ResetColor();
        Console.ReadKey();

        // Замір пам'яті після створення об'єктів
        memoryAfter = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory after creation: {memoryAfter / 1024} KB");

        // Додатковий виклик збирача сміття
        Console.WriteLine("Forcing garbage collection...");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.ResetColor();
        // Замір пам'яті після збору сміття
        long memoryAfterGC = GC.GetTotalMemory(false);
        Console.WriteLine($"Memory after GC: {memoryAfterGC / 1024} KB");

        Console.WriteLine("Program finished. Press any key to exit.");
        Console.ReadKey();
    }
}
