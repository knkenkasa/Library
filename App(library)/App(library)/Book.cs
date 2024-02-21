using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Book
{
    public abstract class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public DateTime PublishDate { get; set; }
        public string Translator { get; set; }


        protected Book(int id, string name, string description, string author, DateTime publishDate, string translator)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            PublishDate = publishDate;
            Translator = translator;
        }
    }
}
