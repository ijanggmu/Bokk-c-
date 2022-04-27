using System;

namespace BookOOP_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //List<int> c = a.enter();
            //List<int> b = a.checkprime(c);
            //a.Display(b);
            Console.WriteLine("Select Operator");
            Console.WriteLine("1 to insert book");
            Console.WriteLine("2 to display all book");
            var userInput = Console.ReadLine();
            int i = 0;
            var bookList = new BookList();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Book Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Book Code:");
                        var code = Console.ReadLine();
                        var newBook = new Subject(name, code);
                        bookList.isValid(newBook);
                        break;
                    case "2":
                        bookList.DisplayBook();
                        break;
                }
                Console.WriteLine("Select Operator Agian");
                userInput = Console.ReadLine();
            }

        }
    }
}
