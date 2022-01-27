using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        int numberOfBooks;
        int numberOfStudents;
        List<string> studentsList = new List<string>();
        List<Book> booksList = new List<Book>();

        public void AddBook(Book book)
        {
            booksList.Add(book);
        }
        public void AddStudent(string NewStudent)
        {
            studentsList.Add(NewStudent);
        }
        public void Write()
        {
            numberOfBooks = booksList.Count;
            numberOfStudents = studentsList.Count;

            string k = "Počet kníh:";
            string s = "Počet Študentov:";
            string jo = k + numberOfBooks + "\n" + s + numberOfStudents;
            Console.WriteLine(jo);
        }

    }
}
