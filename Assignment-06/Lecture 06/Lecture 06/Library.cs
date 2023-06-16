using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LibrarySystem;

namespace LibrarySystem
{
    public class Library
    {

        private Book[] _books = new Book[0];

            public Book this[int i]
            {
                get { return _books[i]; }
                set { _books[i] = value; }
            }

            public int Count
            {
                get { return _books.Length; }
            }

            public void AddBook(Book book)
            {
                var newArray = new Book[Count + 1];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = this[i];
                }

                newArray[Count] = book;
                _books = newArray;
            }

            public void RemoveBook(int index)
            {
                    var newBooksList = _books.ToList();
                    newBooksList.RemoveAt(index);
                    _books = newBooksList.ToArray();
            }
            public void RemoveBookWhitName(string name)
            {
                var newBooksList = _books.ToList();
                Book? bookToRemove = newBooksList.Find(book => book.Title == name);
                if (bookToRemove != null)
                    newBooksList.Remove(bookToRemove);
                _books = newBooksList.ToArray();
            }
        public void FindBook(string name)
            {
                _books.FirstOrDefault(book => book.Title == name).BookInfo();
            }
    }
}
