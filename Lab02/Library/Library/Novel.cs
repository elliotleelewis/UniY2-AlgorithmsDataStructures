using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Novel : Book
    {
        public Novel(string title) : base(title)
        {
            base.Author = new Person("John Green", 39);
        }
    }
}
