using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Domain.Models
{
    public class Solicitation
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string status { get; set; }
        public int user_id { get; set; }
        public Solicitation()
        {

        }
        public Solicitation(int _id, string _title, string _author, string _status, int _user_id)
        {
            id = _id;
            title = _title;
            author = _author;
            status = _status;
            user_id = _user_id;
        }
    }
}
