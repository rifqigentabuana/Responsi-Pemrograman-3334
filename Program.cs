using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3334
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan data1 = new Karyawan("20.11.3334", "Rifqi Genta Buana", 500000);
            Karyawan data2 = new Karyawan("20.11.3334", "Rifqi Genta Buana", 500000 + 500000 *0.1);


            Console.WriteLine("Data Karyawan 1");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nim   : {0}", data1.Nim);
            Console.WriteLine("Nama  : {0}", data1.Nama);
            Console.WriteLine("Gaji  : {0}", data1.Gaji);

            Console.WriteLine();

            Console.WriteLine("Data Karyawan setelah gaji naik ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nim   : {0}", data2.Nim);
            Console.WriteLine("Nama  : {0}", data2.Nama);
            Console.WriteLine("Gaji  : {0}", data2.Gaji);

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
