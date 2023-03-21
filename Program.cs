// See https://aka.ms/new-console-template for more information

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T iSatu, T iDua, T iTiga)
    {
       return ((dynamic)iSatu + (dynamic)iDua + (dynamic)iTiga);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Penjumlahan penjumlahan= new Penjumlahan();
        Console.WriteLine(penjumlahan.JumlahTigaAngka<float>(13, 2, 21));

    }
}