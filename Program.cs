class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите строки массива через пробел: ");
        args = GetArray();

        string[] UpdatedArray = args.Where(i => i.Length < 4).ToArray();

        Console.WriteLine("Вот массив, длина строк в котором меньше, либо равна 3 символам: ");
        PrintArray(UpdatedArray);
    }

    private static string[] GetArray()
    {
        string[] array = Console.ReadLine().Split(' ');
        return array;
    }

    private static void PrintArray(string[] args)
    {
        Console.Write("[ ");
        for (int i = 0; i < args.Length; i++)
        {
            Console.Write(args[i] + " ");
        }
        Console.Write("]");
    }
}