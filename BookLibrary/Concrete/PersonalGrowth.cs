using BookLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Concrete
{
    // a class that is named 'PersonalGrowth' has interited from the abstract class 'Book'
    public class PersonalGrowth: Book
    {
        // Id is needed for Database operations and DatabaseGenerated is required in order 'Id' number to be increased auto
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // type of the books in this class is Personal Growth and cannot be changed
        private string _type = "Personal Growth";


        // Abstract class override method is an obligation.
        public override void GiveBookDetails()
        {
            Console.WriteLine("Type: {0} \nName: {1}\nAuthor: {2}\nPublishDate: {3}\nISBN Number: {4}", _type, Name, Author, PublishDate, IsbnNumber);
        }
    }
}
