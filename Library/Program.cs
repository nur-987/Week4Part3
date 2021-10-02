using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// write a program to issue a book from library, 
    /// to enter the library you need to be a student of the class (need to verify using some roll no etc.) 
    /// but you can only issue one book at a time. 
    /// give the details of student after the book is issued. 
    /// 
    /// Use exception handling to show the error message  
    /// ***use generic class - NOT IMPLEMENTED YET
    /// </summary>
    class Program
    {
        public static List<Book> BookList = new List<Book>();
        public static List<Student> StudentList = new List<Student>();

        static void Main(string[] args)
        {
            AddingBooks(1, "xxx", BookGenre.Children);
            AddingBooks(2, "ppp", BookGenre.Fiction);
            AddingBooks(3, "qqq", BookGenre.Horror);
            AddingBooks(4, "sss", BookGenre.NonFicton);
            AddingBooks(5, "kkk", BookGenre.SeriesCollection);

            AddingStudent(1, "Jane");
            AddingStudent(2, "Harry");
            AddingStudent(3, "Philip");
            AddingStudent(4, "Lea");
            AddingStudent(5, "April");

            Console.WriteLine("Welcome to Library.");
            bool b = true;
            while (b)
            {
                Console.WriteLine("Would you like to BORROW? Y/N");
                string input = Console.ReadLine();
                if(input == "Y")
                {
                    int tempId = 0;
                    Console.WriteLine("please input Student ID");
                    try
                    {
                        tempId = Int32.Parse(Console.ReadLine());
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine($"Error! {ex.Message}");
                    }
                    try
                    {
                        CheckEligibility(tempId);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error! {ex.Message}");
                        Console.WriteLine("ID not vaid");
                    }
                    

                }
                else if(input == "N")
                {
                    b = false;
                    Console.WriteLine("closing...");
                    Console.ReadLine();

                }
                else
                {
                    throw new Exception("Input not applicable. Try again");
                    //wrong input. Not Y or N
                }
            }
        }

        public static void AddingBooks(int id, string title, BookGenre genre)
        {
            Book newBook = new Book(id, title, genre)
            {
                BookId = id,
                Title = title,
                bookGenre = genre
            };
            BookList.Add(newBook);
        }

        public static void BorrowBook()
        {
            Console.WriteLine("Here are the books available: ");

            foreach (Book item in BookList)
            {
                Console.Write("Book ID: " + item.BookId);
                Console.WriteLine(" - Title: " + item.Title);
            }

            Console.WriteLine("Please input the book ID that you would like to borrow");
            int input = 0;
            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }


            foreach (Book item in BookList)
            {
                if (input == item.BookId)
                {
                    Console.WriteLine("You Chose this book to borow");
                    Console.WriteLine(item.Title);
                    Console.WriteLine(item.bookGenre);

                    //not geting the current students id

                    //Student currenStud = new Student();
                    //Console.WriteLine(currenStud.StudentId);
                    //Console.WriteLine(currenStud.Name);

                }
            }

        }

        public static void AddingStudent(int id, string name)
        {
            Student newStudent = new Student(id, name)
            {
                StudentId = id,
                Name = name
            };
            StudentList.Add(newStudent);
        }

        public static void CheckEligibility(int id)
        {

            foreach (Student item in StudentList)
            {
                if (item.StudentId == id)
                {
                    Console.WriteLine("Student is valid. You may proceed to borrow a book");
                    BorrowBook();
                }

            }

                throw new Exception();
                //student does not exist
        }
    }
}
