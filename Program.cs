using System;

namespace Pemrogaman_Interface_2680
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm     = "19.11.2680";
            mhs.nama    = "Fajar Trinanda Yuvianto";
            mhs.email   = "fajar.yuvianto@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data : ");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("1. Csv\n");

            Console.Write("Nomor Format Data [1-3] : ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());
	    
	    //deklarasi objek konversi
            IConvertObject convert; 

            if(nomorFormatData == 1)
                convert = new ConvertToJson();
            else if(nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            //konversi objek mhs berdasarkan format yang telah dipilih 
            convert.Convert(mhs);

            Console.ReadKey();

        }
    }
}