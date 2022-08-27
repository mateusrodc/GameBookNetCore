using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Domain.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public int max_score { get; set; }
        public int pages { get; set; }
        public int author_id { get; set; }
        public Book()
        {

        }
        public Book (int _id, string _title, int _max_score, int _pages, int _author_id)
        {
            id = _id;
            title = _title;
            max_score = _max_score;
            pages = _pages;
            author_id = _author_id;
        }
    }
}
