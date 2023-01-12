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
}