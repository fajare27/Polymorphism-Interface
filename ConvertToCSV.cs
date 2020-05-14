//konversi objek mahasiswa ke csv

using System;

public class ConvertToCsv : IConvertObject  
{
    public void Convert(Mahasiswa mhs)
    {
        string csv = string.Format("{0},{1},{2},",mhs.npm,mhs.nama,mhs.email);
            
        Console.WriteLine("\nHasil konversi ke csv :\n");
        Console.WriteLine(csv);
    }
}