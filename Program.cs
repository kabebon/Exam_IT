class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите строки массива через пробел: ");
        args = GetArray();
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