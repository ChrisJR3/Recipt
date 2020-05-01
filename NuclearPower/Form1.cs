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
        List<Object> books = new List<Object>();
        //Just the reference number list
        List<int> referenceList = new List<int>();

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
                
                referenceList.Add(referenceNumber);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchNumber = Convert.ToInt32(referenceNumberTextBox.Text);

            //linear search
            Boolean linearSucess = linearSearch(referenceList, searchNumber);
            if (linearSucess == true)
            {
                linearSearchTextBox.Text = Convert.ToString(books[searchNumber]);
            }
            else
            {
                linearSearchTextBox.Text = "No book was found under that search, please try again.";
            }

            //binary search
            Boolean binarySucess = binarySearch(referenceList, searchNumber);
            if (binarySucess == true)
            {
                binarySearchTextBox.Text = Convert.ToString(books[searchNumber]);
            }
            else
            {
                binarySearchTextBox.Text = "No book was found under that search, please try again.";
            }
        }

        public Boolean linearSearch(List<int> bookList, int searchNumber)
        {
            foreach (int b in bookList)
            {
                if (b == searchNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean binarySearch(List<int> bookList, int searchNumber)
        {
            int low = 0;
            int high = bookList.Count - 1;

            while (high >= low)
            {
                int middle = (low + high) / 2;

                if (Convert.ToInt32(bookList[middle]) == searchNumber)
                {
                    return true;
                }
                else if (Convert.ToInt32(bookList[middle]) < searchNumber)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return false;
        }
    }
}
