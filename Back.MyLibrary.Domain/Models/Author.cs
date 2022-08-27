using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Domain.Models
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public Author()
        {

        }
        public Author(string _name)
        {
            name = _name;
        }
    }
}
