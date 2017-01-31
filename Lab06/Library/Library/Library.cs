using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Properties;
namespace Library
{
    internal partial class Library : Form
    {
        public Dictionary<string, Book> Books;
        public Library()
        {
            InitializeComponent();
            Books = new Dictionary<string, Book> {
                {"9780746062760", new Book("9780746062760", "Moby Dick")},
                {"9780747532743", new Book("9780747532743", "Harry Potter and the Philosopher's Stone")},
                {"9780451119674", new Book("9780451119674", "The Shining")},
                {"9785170686773", new Book("9785170686773", "Pet Sematary")},
                {"9780147513731", new Book("9780147513731", "The Fault in Our Stars")},
                {"9781423344254", new Book("9781423344254", "Paper Towns")},
                {"9780553386790", new Book("9780553386790", "A Game of Thrones")},
                {"9784150116132", new Book("9784150116132", "A Clash of Kings")}
            };
            RefreshTable();
        }
        private void RefreshTable()
        {
            var selectedColumn = -1;
            var selectedRow = -1;
            if (dataGridView.CurrentCell != null) {
                selectedColumn = dataGridView.CurrentCell.ColumnIndex;
                selectedRow = dataGridView.CurrentCell.RowIndex;
            }
            var filteredLibrary = (from book in Books
                where
                ((Book) book.Value).Title.ToLower().Trim().Contains(TextBoxSearch.Text.ToLower().Trim()) ||
                ((Book) book.Value).Isbn.ToLower().Trim().Contains(TextBoxSearch.Text.ToLower().Trim())
                select book.Value).ToList();
            dataGridView.DataSource = (from row in filteredLibrary
                select new {
                    ISBN = row.Isbn,
                    Title = row.Title,
                    OnLoan = row.OnLoan
                }).ToArray();
            if (dataGridView.RowCount > 0 && selectedColumn >= 0 && selectedRow >= 0) {
                if (selectedRow > dataGridView.RowCount - 1) {
                    dataGridView.CurrentCell = dataGridView[selectedColumn, dataGridView.RowCount - 1];
                }
                else {
                    dataGridView.CurrentCell = dataGridView[selectedColumn, selectedRow];
                }
            }
        }
        private void ButtonToggle_Click(object sender, EventArgs e)
        {
            ((Book) Books.ElementAt(dataGridView.CurrentCell.RowIndex).Value).OnLoan ^= true;
            RefreshTable();
        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            new AddBook().Show();
        }
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.sure, "", MessageBoxButtons.YesNo) == DialogResult.Yes &&
                dataGridView.CurrentRow != null) {
                Books.Remove(dataGridView.CurrentRow.Cells[0].Value.ToString());
                RefreshTable();
            }
        }
        public bool AddBook(Book book)
        {
            if (!Books.ContainsKey(book.Isbn)) {
                Books.Add(book.Isbn, book);
                RefreshTable();
                return true;
            }
            MessageBox.Show(Resources.exists, "", MessageBoxButtons.OK);
            return false;
        }
    }
}