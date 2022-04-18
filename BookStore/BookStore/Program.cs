using System;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("BOOK STORE Welcome");
                Console.WriteLine("Butun kitablari gormek isteyirsiz?Y/N");

                if ((char)Console.ReadKey().Key == 'Y' || (char)Console.ReadKey().Key == 'y')
                {

                    Console.WriteLine("  ");
                    Console.WriteLine("Kitablar:");
                    Console.WriteLine("________________________");
                    BookStoreBuySalling.GetAll();
                    Console.WriteLine("________________________");
                    Console.WriteLine("Almaq isdediyiniz kitabin id-sini daxil edin!");
                    BookStoreBuySalling.GetBuyBook(int.Parse(Console.ReadLine()));
                }
                else Console.WriteLine("Sagolun");
        }
       

       

    }
}

