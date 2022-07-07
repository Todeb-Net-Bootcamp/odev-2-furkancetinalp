using BookLibrary.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DBOperations
{
    // To have some inputs inside the database that has been set up, we need to initialize an action
    public class DataGenerate
    {
        public static void Initialize()
        {
            using (var context = new BookLibraryDbContext())
            {
                if(context.Stories.Any())
                {
                    return;
                }
                //Adding Story variables inside the Stories table in Db
                context.Stories.AddRange(
                    new Story
                    {
                        Name ="Hayatın Anlamı",
                        Author = "Tolstoy",
                        IsbnNumber = 888,
                        PublishDate = new DateTime(1860, 02, 20)
                    },
                    new Story
                    {
                        Name = "Ölüme Boyun Eğmeyen Adam",
                        Author = "Jack London",
                        IsbnNumber = 777,
                        PublishDate = new DateTime(1903, 12, 11)
                    }
                    );

                //Adding Novel variables inside the Novels table in Db
                context.Novels.AddRange(
                    new Novel
                    {
                        Name = "Faust",
                        Author = "Goethe",
                        IsbnNumber = 222,
                        PublishDate = new DateTime(1682, 03, 11)
                    },
                    new Novel
                    {
                        Name = "Ev Sahibesi",
                        Author = "Dostoyevski",
                        IsbnNumber = 999,
                        PublishDate = new DateTime(1834, 02, 05)
                    }
                    );
                //Adding PersonalGrowth variables inside the PersonalGrowths table in Db
                context.PersonalGrowths.AddRange(
                    new PersonalGrowth
                    {
                        Name = "Sır",
                        Author = "Rhonda Byrne",
                        IsbnNumber = 111,
                        PublishDate = new DateTime(2000, 01, 22)
                    },
                    new PersonalGrowth
                    {
                        Name = "Beden Dili",
                        Author = "Joe Navarro",
                        IsbnNumber = 100,
                        PublishDate = new DateTime(2010, 04, 09)
                    }
                    );

                //After making an action, save prompt is required.
                context.SaveChanges();
            }
        }
    }
}
