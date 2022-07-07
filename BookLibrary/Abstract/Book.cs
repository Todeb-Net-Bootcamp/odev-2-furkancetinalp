using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Abstract
{
    //Abstract class set up
    public abstract class Book
    {
        // These variables are private and will be encapsulated
        private string _isbnNumber;
        private string _name;
        private string _author;
        private DateTime _publishDate;

       
        // Encapsulation  => for _isbnNumber
        // int value will be taken and converted to string via Encapsulation
        public int IsbnNumber
        {
            get { return Convert.ToInt32(_isbnNumber); }
            set { _isbnNumber = value.ToString(); }
        }
        //Encapsulation => for _name 
        //setter and getter methods are for user interaction
        public string Name { get => _name;set {_name = value; } }
        //Encapsulation => for _author
        public string Author { get => _author; set { _author = value; } }
        //Encapsulation for _publishDate
        //The program will check if the user's 'Datetime' input is later than today
        //if so; the program won't allow this variable to be set up  ' _publishDate '
        public DateTime PublishDate
        {
            get { return _publishDate; }
            set
            {
                int result = DateTime.Compare(value, DateTime.Today);
                if (result < 0)
                {
                    _publishDate = value;
                }
                else
                {
                    Console.WriteLine("Datetime cannot be later than date of today");
                }
            }
        }
        // Each class that inherits that class has to override this method in terms of its own variables
        public abstract void GiveBookDetails();

    }
}
