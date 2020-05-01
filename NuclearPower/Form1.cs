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
        //Full book list
        List<Book> books = new List<Book>();

        //Booleans for file and help button
        Boolean fileVisible = false;
        Boolean helpVisible = false;

        int searchNumber;

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
            searchNumber = Convert.ToInt32(referenceNumberTextBox.Text);

            //linear search
            String linearSearchResult = linearSearch(books, searchNumber);
            linearSearchTextBox.Text = linearSearchResult;
            
            //binary search
            String binarySearchResult = binarySearch(books, searchNumber);
            binarySearchTextBox.Text = binarySearchResult;

            //confiriming the validity of the search
            if (linearSearchTextBox.Text == binarySearchTextBox.Text)
            {
                validityTextBox.Text = "Search preformed successfully.";
            }
            else
            {
                validityTextBox.Text = "Search preformed unsuccessfully.";
            }
        }

        public string linearSearch(List<Book> bookList, int searchNumber)
        {
            foreach (Book b in bookList)
            {
                if (b.referenceNumber == searchNumber)
                {
                    return b.bookTitle;
                }
            }
            return "There was no book found under that reference number, please try again.";
        }

        public string binarySearch(List<Book> bookList, int searchNumber)
        {
            int low = 0;
            int high = bookList.Count - 1;

            while (high >= low)
            {
                int middle = (low + high) / 2;

                if (bookList[middle].referenceNumber == searchNumber)
                {
                    return bookList[middle].bookTitle;
                }
                else if (bookList[middle].referenceNumber < searchNumber)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return "There was no book found under that reference number, please try again.";
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            helpLabel.Visible = false;
            helpVisible = false;

            if (fileVisible == false)
            {
                fileLabel.Visible = true;
                fileVisible = true;
            }
            else
            {
                fileLabel.Visible = false;
                fileVisible = false;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            fileLabel.Visible = false;
            fileVisible = false;

            if (helpVisible == false)
            {
                helpLabel.Visible = true;
                helpVisible = true;
            }
            else
            {
                helpLabel.Visible = false;
                helpVisible = false;
            }
        }
    }
}
