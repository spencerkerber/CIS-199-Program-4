// Spencer Kerber
// CIS 199-01
// Program 4
// Due 12/8/14
// Library book
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Form1 : Form
    {
        List<LibraryBook> bookList = new List<LibraryBook>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void GetBookInfo(LibraryBook book)
        {
            book._title = titleTextBox.Text;                    // precondition: must have text
            book._author = authorTextBox.Text;                  // precondition: must have text
            book.Publisher = publisherTextBox.Text;             // precondition: must have text
            book._copyright = int.Parse(copyrightTextBox.Text); // precondition: must have integer
            book.CallNumber = callNumberTextBox.Text;           // precondition: must have text                    
        }

        private void button1_Click(object sender, EventArgs e)  // precondition: all textboxes must have correct data type entered
        {                                                       
            LibraryBook myBook = new LibraryBook();
            {
                GetBookInfo(myBook);
                bookList.Add(myBook);
                bookListBox.Items.Add(myBook.Title);

                titleTextBox.Clear();
                authorTextBox.Clear();
                publisherTextBox.Clear();
                copyrightTextBox.Clear();
                callNumberTextBox.Clear();

                titleTextBox.Focus();          // postcondition: new item in listbox and all textboxes are empty                                                        
            }
        }

        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {                                  
        }
       
        private void checkOutButton_Click(object sender, EventArgs e)       // precondition: must have item in listbox
        {
            int index = bookListBox.SelectedIndex;                          // integer that holds selected position in listbox
            if (index < 0)
                MessageBox.Show("Please Select a Book");
            else
            {
                bookList[index].CheckOut();
                MessageBox.Show("The specified book has been checked out"); // postcondition: item is checked out or user is prompted to select item
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)        // precondition: must have item in listbox
        {
            int index = bookListBox.SelectedIndex;                          // integer that holds selected position in listbox
            if (index < 0)
                MessageBox.Show("Please Select a Book");
            else
                MessageBox.Show(bookList[index].ToString());                // postcondition: details box appears or user is prompted to select an item     
        }

        private void returnButton_Click(object sender, EventArgs e)         // precondition: must have item in listbox
        {
            int index = bookListBox.SelectedIndex;                          // integer that holds selected position in listbox
            if (index < 0)
                MessageBox.Show("Please Select a Book");
            else
            {
            bookList[index].ReturnToShelf();                          
                MessageBox.Show("The specified book has been reshelved");   // postcondition: item is checked in or user is prompted to select an item
            }
        }                                                
    }
}
