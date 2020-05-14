//konversi objek mahasiswa ke json

using System;
using Newtonsoft.Json;

public class ConvertToJson : IConvertObject
{
    public void Convert(Mahasiswa mhs)
    {
        string json = JsonConvert.SerializeObject(mhs);

        Console.WriteLine("\nHasil Konversi ke json:\n");
        Console.WriteLine(json);
    }