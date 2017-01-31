using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Library
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (Program.GetLibrary().AddBook(new Book(TextISBN.Text, TextTitle.Text))) {
                Close();
            }
        }
    }
}