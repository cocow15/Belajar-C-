using System;

namespace DataDiri
{
    class Program
    {
        static void Main(string[] args)
        {
            string? firstName = null;
            string? lastName = null;
            Console.Write("Masukkan Nama Depan Anda: ");
            firstName = Console.ReadLine();

            Console.Write("Masukkan Nama Belakang Anda: ");
            lastName = Console.ReadLine();

            if (firstName != null && lastName != null)
            {
                Console.WriteLine("Nama Anda Adalah " + firstName + " " + lastName); // Use the variable
            }
        }
    }
}
