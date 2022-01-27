using System;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schoolLibrary = new Library();

            schoolLibrary.AddStudent("John");
            schoolLibrary.AddStudent("Poul");

            Book zaklinac = new Book("Zaklínač", 200, "Fantasy", "Sapkowski", 1993);
            Book metro2033 = new Book("Metro2033", 350, "Sci-fi", "Gluchovskij", 2005);

            schoolLibrary.AddBook(zaklinac);
            schoolLibrary.AddBook(metro2033);

            schoolLibrary.Write();
        }
    }
}
