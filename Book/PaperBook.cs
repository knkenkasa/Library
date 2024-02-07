using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Book
{
    public class PaperBook : Book
    {
        public PaperBook(int id, string name, string description, string author, DateTime publishDate, string translator) : base(id, name, description, author, publishDate, translator)
        {
        }
    }
}
