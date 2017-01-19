using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Fantasy : Book
    {
        public Fantasy(string title) : base(title)
        {
            base.Author = new Person("George R. R. Martin", 68);
        }
    }
}
