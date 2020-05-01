using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;

namespace NuclearPower
{
    public partial class Background : Form
    {
        List<Object> books = new List<Object>();

        public Background()
        {
            InitializeComponent();
        }

        private void Background_Load(object sender, EventArgs e)
        {
            List<String> bookList = File.ReadAllLines("booksFile (1).txt").ToList();

            for (int i = 0; i < bookList.Count; i += 2)
            {
                int referenceNumber = Convert.ToInt32(bookList[i]);
                string bookTitle = bookList[i + 1];

                Book b = new Book(referenceNumber, bookTitle);
                books.Add(b);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //linear search
            linearSearch(books, Convert.ToInt32(referanceNumberTextBox.Text));

            //binary search

        }

        public Boolean linearSearch(List<object> bookList, int searchNumber)
        {
            foreach (string s in bookList)
            {
                if (s == searchNumber)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
