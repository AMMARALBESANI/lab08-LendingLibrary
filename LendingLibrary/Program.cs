using LendingLibrary.Casses;

namespace LendingLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            library.Add("love", "Ammar", "albesani", 50);
            library.Add("how to learn", "Ammar", "albesani", 100);
            library.Add("scape", "Ammar", "albesani", 25);
            library.print();
            Console.WriteLine();
            library.Borrow("love");
            library.print();
            Console.WriteLine();

            library.Return(new Book ("love", "Ammar", "albesani", 50));
            library.print();
            Console.WriteLine();

            BackPack < Book> backpack = new BackPack< Book> ();
            backpack.Pack(new Book("Mylive", "Ammar", "albesani", 50));
            backpack.Pack(new Book("build your future", "Ammar", "albesani", 50));
            backpack.Pack(new Book("five reasons to learn", "Ammar", "albesani", 50));
            backpack.print();
            Console.WriteLine();
            backpack.Unpack(2);
            backpack.print();



        }
    }
}