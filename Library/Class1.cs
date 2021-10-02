using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    enum BookGenre
    {
        Fiction, NonFicton, Horror, SeriesCollection, Children
    }

    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public BookGenre bookGenre { get; set; }

        public Book(int id, string title, BookGenre genre)
        {
            BookId = id;
            Title = title;
            bookGenre = genre;
        }

    }

    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        List<Book> BooksBorrowed = new List<Book>();


        public Student(int id, string name)
        {
            StudentId = id;
            Name = name;
        }

        public Student()
        {
        }
    }
}
