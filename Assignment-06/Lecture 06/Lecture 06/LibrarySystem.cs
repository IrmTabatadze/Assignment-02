using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _year;
        private string _genre;

        public string Title
        { 
            get {   return _title; } 
            set {  _title = value; } 
        }

        public string Author
        { get { return _author; } set {  _author = value; } }

        public int Year
        { get { return _year; } set { _year = value; } }

        public string Genre
        { get { return _genre; }  set { _genre = value; } }

        public Book()
        {
        }

        public Book(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }
        public void BookInfo()
        {
            Console.WriteLine($"{Title} / {Author} / {Year} / {Genre}");
        }
    }
}
