﻿using System;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book book;
            Book[] books = new Book[3];
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write("Kitab adi daxil edin:  ");
                string name = Console.ReadLine();
                while (!CheckName(name))
                {
                    Console.WriteLine("Duzgun ad daxil edin");
                    name = Console.ReadLine();
                }
                
                Console.Write("Kitab sehifesi daxil edin:  ");
                int PageCount = int.Parse(Console.ReadLine());
                while (!CheckPageCount(PageCount))
                {
                    Console.WriteLine("Duzgun page daxil edin");
                    PageCount = int.Parse(Console.ReadLine());
                }
                while (!Search(name, PageCount))
                {
                    Console.WriteLine("Bele kitab movcuddur name ve ya page-i duzgun daxil edin  ");
                    Console.WriteLine("Duzgun name daxil edin   ");
                    name= Console.ReadLine();
                    Console.WriteLine("Duzgun page daxil edin");
                    PageCount = int.Parse(Console.ReadLine());
                }
                book = new Book(name, PageCount, books);
                books[i] = book;

            }


            bool CheckName(string name)
            {
                if (name.Length > 3)
                {
                    return true;
                }
                return false;
            }
            bool CheckPageCount(int PageCount)
            {
                if (PageCount > 10)
                {
                    return true;
                }
                return false;
            }
            bool Search(string name, int pagecount)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] != null)
                    {
                        if (name == books[i].Name && pagecount == books[i].PageCount)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            foreach (var item in books)
            {
                Console.WriteLine($"Name: {item.Name}        Page: {item.PageCount}");
            }
            Console.ReadKey();
        }
    }
}
