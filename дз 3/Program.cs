Console.Clear();
double[] startArray = GetArray(5);
Console.WriteLine(String.Join("/", startArray));
Console.WriteLine($"Разница = {GetDifference(startArray)}");
double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 10 - 5;
        res[i] = Math.Round(res[i], 3);
    }
    return res;
}
double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (double el in array)
    {
        if (min > el) min = el;
        if (max < el) max = el;
    }
    return max - min;
}