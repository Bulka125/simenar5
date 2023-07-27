class Program
{
    static void Main(string[] args)
    {
        int size = 4;
        
        Random rand = new Random();

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(-100, 101);
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int sum = 0;
        for (int i = 1; i < size; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);

        Console.ReadKey();
    }
}