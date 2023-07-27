class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[4];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
            Console.WriteLine(array[i]);
        }

        int count = 0;

        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество четных чисел в массиве: " + count);
    }
}