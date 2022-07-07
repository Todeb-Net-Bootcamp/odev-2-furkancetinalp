using BookLibrary.Concrete;
using BookLibrary.DBOperations;
using System;
using System.Linq;

namespace BookLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To initialize database operations
            DataGenerate.Initialize();
            BookLibraryDbContext _context = new BookLibraryDbContext();
            var stories = _context.Stories.ToList<Story>();

            //At first, each book tables(type) has 2 data inside.
            Console.WriteLine("GENRE TYPE: STORY");
            foreach (var story in _context.Stories)
            {
                story.GiveBookDetails();
                Console.WriteLine("*****************");
            }
            Console.WriteLine("\n");
            Console.WriteLine("GENRE TYPE: NOVEL");
            foreach (var story in _context.Novels)
            {
                story.GiveBookDetails();
                Console.WriteLine("*****************");
            }
            Console.WriteLine("\n");
            Console.WriteLine("GENRE TYPE: PERSONAL GROWTH");
            foreach (var story in _context.PersonalGrowths)
            {
                story.GiveBookDetails();
                Console.WriteLine("*****************");

            }
            Console.WriteLine("\n\n");

            //Adding a Story book data inside Stories table

            Story book_story_type = new Story();
            book_story_type.Name = "Her Şeye Rağmen Sevgi";
            book_story_type.PublishDate = new DateTime(1870, 06, 05);
            book_story_type.Author = "Tolstoy";
            book_story_type.IsbnNumber = 10;
            
            _context.Stories.Add(book_story_type);
            _context.SaveChanges();

            //Adding a Novel book data inside Novels table
            Novel book_novel = new Novel();
            book_novel.Name = "Suç ve Ceza";
            book_novel.PublishDate = new DateTime(1866, 10, 02);
            book_novel.Author = "Dostoyevski";
            book_novel.IsbnNumber = 77;

            _context.Novels.Add(book_novel);
            _context.SaveChanges();

            //Adding a PersonalGrowth book data inside PersonalGrowths table
            PersonalGrowth book_pg = new PersonalGrowth();
            book_pg.Name = "Brief";
            book_pg.PublishDate = new DateTime(2012, 01, 12);
            book_pg.Author = "Joseph McCormack";
            book_pg.IsbnNumber = 33;

            _context.PersonalGrowths.Add(book_pg);
            _context.SaveChanges();


            //After adding inputs inside the tables, Each tables to be printed:
            Console.WriteLine("GENRE TYPE: STORY");
            foreach (var story in _context.Stories)
            {
                story.GiveBookDetails();
                Console.WriteLine("*****************");
            }
            Console.WriteLine("\n");
            Console.WriteLine("GENRE TYPE: NOVEL");
            foreach (var story in _context.Novels)
            {
                story.GiveBookDetails();
                Console.WriteLine("*****************");
            }
            Console.WriteLine("\n");
            Console.WriteLine("GENRE TYPE: PERSONAL GROWTH");
            foreach (var story in _context.PersonalGrowths)
            {
                story.GiveBookDetails();
                Console.WriteLine("*****************");

            }
        }
    }
}
