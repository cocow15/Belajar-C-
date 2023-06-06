using System;

namespace Alamat
{
    class Program
    {
        static void Main(string[] args)
        {
            string? name = null;
            string? address = null;
            //int? age = null;
            Console.Write("Masukkan Nama Anda: ");
            name = Console.ReadLine();

            Console.Write("Masukkan Alamat Rumah Anda: ");
            address = Console.ReadLine();

            Console.Write("Berapakah Usia Anda: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nama Anda Adalah " + name + "\n" +"Rumah Anda berada di " + address + "\n" + "Umur anda adalah " + age);
        }
    }
}
