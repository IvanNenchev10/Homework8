using System;
namespace Домашна_8
{
    class Program
    {
        class Base
        {
            protected int pages;
            protected int yearOfRelease;
            public Base()
            {
                pages = 0;
                yearOfRelease = 0;
            }
            public Base(int pages,int yearOfRelease)
            {
                this.pages = pages;
                this.yearOfRelease = yearOfRelease;
            }
            public int Pages
            {
                set { pages = value;}
                get { return pages;}
            }
            public int YearOfRelease
            {
                set { pages = value;}
                get { return yearOfRelease;}
            }
        }
        class Book:Base
        {
            private string author;
            private string caption;
            public Book()
            {
                author = null;
                caption = null;
            }
            public Book(string author,string caption,int pages,int yearOfRelease):base(pages,yearOfRelease)
            {
                this.author = author;
                this.caption = caption;
            }
            public string Author
            {
                set { author = value; }
                get { return author; }
            }
            public string Caption
            {
                set { caption = value; }
                get { return caption; }
            }
            public void Print(int page)
            {
                if(page>pages || page<0)
                {
                    Console.WriteLine("Invalid page");
                }
                else
                {
                    Console.WriteLine("Page:{0}", page);
                }
            }
        }
        class Dictionary:Base
        {
            private string name;
            private int numberOfStudents;
            public Dictionary()
            {
                name = null;
                numberOfStudents = 0;
            }
            public Dictionary(string name,int numberOfStudents,int pages,int yearOfRelease):base(pages,yearOfRelease)
            {
                this.name = name;
                this.numberOfStudents = numberOfStudents;
            }
            public string Name
            {
                set { name = value; }
                get { return name; }
            }
            public int NumberOfStudents
            {
                set { numberOfStudents = value; }
                get { return numberOfStudents; }
            }
            public double AverageMark(double[] arr)
            {
                double sum = 0;
                for(int i=0;i<arr.Length;i++)
                {
                    sum = sum + arr[i];
                }
                Console.Write("Average mark of all students is: ");
                return sum / arr.Length;
            }
        }
        static void Main()
        {
            Book book = new Book("Ivan Vazov", "Pod Igoto", 500, 1881);
            int page;
            Console.WriteLine("Enter page to print:");
            page = int.Parse(Console.ReadLine());
            book.Print(page);
            Dictionary dictionary = new Dictionary("Dnevnik", 10, 100, 2019);
            double[] arr = new double[dictionary.NumberOfStudents];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter mark for student {0}", i + 1);
                arr[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}", dictionary.AverageMark(arr));
        }
    }
}
