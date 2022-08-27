using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Domain.Models
{
    public class Read
    {
        public int id { get; set; }
        public int score { get; set; }
        public int pages { get; set; }
        public int book_id { get; set; }
        public int user_id { get; set; }
        public Read()
        {

        }
        public Read (int _id, int _score, int _pages, int _book_id, int _user_id)
        {
            id = _id;
            score = _score;
            pages = _pages;
            book_id = _book_id;
            user_id = _user_id;
        }
    }
}
