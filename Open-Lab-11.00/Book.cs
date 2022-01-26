using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public static List<string> categoryList = new List<string>
        {
            "detské", "romantické", "náučné", "sci-fi", "dobrodružné"
        };

        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }
        public string Title { get; set; }     
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }
        }
        public string Category { get; set; }

        public string Author { get; set; }
        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value <= 2021 && value >= 1450)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
        }
        public override string ToString()
        {
            return Title + "\n" + Pages + "\n" + Category + "\n" + Author + "\n" + releaseDate;
        }
    }
}
