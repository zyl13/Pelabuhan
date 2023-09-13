using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input Data:");
        
        Console.Write("Negara: ");
        string negara = Console.ReadLine();
        
        Console.Write("Pelabuhan: ");
        string pelabuhan = Console.ReadLine();
        
        Console.Write("Barang: ");
        string barang = Console.ReadLine();
        
        Console.Write("Harga: ");
        decimal harga = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Tarif Bea Masuk: ");
        decimal tarifBeaMasuk = Convert.ToDecimal(Console.ReadLine());
        
        Console.WriteLine("\nData Inputted:");
        Console.WriteLine($"Negara: {negara}");
        Console.WriteLine($"Pelabuhan: {pelabuhan}");
        Console.WriteLine($"Barang: {barang}");
        Console.WriteLine($"Harga: {harga:C}");
        Console.WriteLine($"Tarif Bea Masuk: {tarifBeaMasuk:P}");
    }
}
