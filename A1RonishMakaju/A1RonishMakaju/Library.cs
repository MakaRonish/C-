using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1RonishMakaju
{
    public class Library
    {
        Book[] _Books =
        {
            new Book("The Great Gatsby","F. Scott Fitzgerald",3),
            new Book("To Kill a Mockingbird"," Harper Lee",5),
            new Book("Atomic habits","James Clear",2),
            new Book("Pride and Prejudice", "Jane Austen", 3),
            new Book("The Alchemist", "Paulo Coelho", 6)


        };

        public bool numberchecker(string number)
        {
            int i;
            bool is_num = int.TryParse(number, out i);
            return is_num;
        }

        public Book[] books
        {
            get { return _Books; }
        }

        public void available_books()
        {
            Console.WriteLine("\nAvailable Books:");
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1}. {books[i].Title} by {books[i].Author} - Available: {books[i].AvailableCopies}/{books[i].TotalCopies}");
            }
            Console.WriteLine("");
        }

        public void borrow()
        {
            bool validate = false;

            while (!validate)
            {
                available_books();
                Console.WriteLine("Enter book number you want to borrow:");
                string book_no = Console.ReadLine();
                
                if (numberchecker(book_no))
                {
                    int b_no = Int32.Parse(book_no);
                    if (b_no > 0 && b_no < books.Length+1)
                    {
                        books[b_no - 1].BorrowBooks();
               
                        validate = true;

                    }
                    else
                    {
                        Console.WriteLine($"Pls Choose the currect number range from 1 to {books.Length}");
                    }
                }
                else
                {
                    Console.WriteLine("Pls enter a valid number");
                }
            }

            
        }

        public void ReturnBook()
        {
            bool Validate_bname = false;
            while (!Validate_bname)
            {
                available_books();
                Console.WriteLine("Enter the book title name you want to return :");
                string book_name = Console.ReadLine();
                for (int i = 0; i < books.Length; i++)
                {
                    Book cur_book = books[i];
                    string book_title = cur_book.Title;
                    if (book_name.ToLower() == book_title.ToLower())
                    {
                        if (cur_book.AvailableCopies < cur_book.TotalCopies) { 
                        Console.WriteLine($"\nThanks for returning {cur_book.Title} by {cur_book.Author} \nHopefully you enjoyed reading this book");
                        cur_book.AvailableCopies++;
                        
                        Validate_bname=true;
                        break;
                        }
                        else
                        {
                            Console.WriteLine("\nYou have never borrowed this book from us");

                        }
                    }
                }
                if (!Validate_bname) { Console.WriteLine($"book not found: {book_name}");
                    
                }
                
            }
        }

        public void runprogram()
        {
            Console.WriteLine("Welcome to Library System!\n ");
            
            bool userlogoff = false;
            while (!userlogoff)
            {
                available_books();
                Console.WriteLine("Options:\n1. Borrow a book\n2. Return a Book\n3. Quit\nChoose an option: ");

                string option = Console.ReadLine();

                if (numberchecker(option))
                {
                    int opt = Int32.Parse(option);
                    if (opt == 1)
                    {
                        borrow();
                    }
                    else if (opt == 2)
                    {
                        ReturnBook();
                    }
                    else if (opt == 3) {
                        Console.WriteLine("\nThanks for using the library see you soon");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option pls choose 1,2,3");
                    }
                }

                


            }


        



        }



    }
}
