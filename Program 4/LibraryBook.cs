// Spencer Kerber
// CIS 199-01
// Program 4
// Due 12/8/14
// Library book
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class LibraryBook
    {
        public string _title;
        public string _author;
        public string _publisher;
        public int _copyright;
        public string _callNumber;        

        public LibraryBook(string t = " ", string a = " ", string p = " ", int c = 0, string cn = " ")  // constructor that accepts 5 arguments
        {
            chosenBook(t, a, p, c, cn);   // validate Library book by invoking chosenBook
        }
       
        public void chosenBook(string t, string a, string p, int c, string cn)
        {
            Title = t;          // set Title property                                   
            Author = a;         // set Author property
            Publisher = p;      // set Publisher property
            CopyrightYear = c;  // set CopyrightYear property
            CallNumber = cn;    // set CallNumber property
        }
      
        public string Title     // property that gets and sets the Title
        {
            get
            {
                return _title;
            }
            private set
            {
                _title = value;
            }                         
        }
        public string Author    // property that gets and sets the Author
        {
            get
            {
                return _author;
            }
            private set
            {
                _author = value;
            }
        }
        public string Publisher // property that gets and sets the Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }
        public int CopyrightYear    // property that gets and sets the CopyrightYear
        {
            get
            {
                return _copyright;
            }
            private set
            {
                if (value > 0) _copyright = value;
                else _copyright=0;
            }
        }
        public string CallNumber    // property that gets and sets the call number
        {
            get
            {
                return _callNumber;
            }
            set
            {
                _callNumber = value;
            }
        }
        bool status;            // bool that holds book's checked out status
        public void CheckOut()  // method that changes book's checked out status to checked out
        {
            status = true;
        }
        public void ReturnToShelf() // method that changes book's checked out status to checked in
        {
            status = false;
        }
        public bool IsCheckedOut    // method that returns true if book is checked out and false if book is checked in
        {
            get
            {
                return status;
            }
            set
            {
                if (status == true) IsCheckedOut = true;
                else IsCheckedOut = false;
            }
        }                          
       
        public override string ToString()
        {
            string result;  // holds details of book
            result = "Title: " + Title + System.Environment.NewLine + "Author: " + Author + System.Environment.NewLine + "Publisher: " + Publisher + System.Environment.NewLine + "Copyright Year: " + CopyrightYear + System.Environment.NewLine + "Call Number: " + CallNumber + System.Environment.NewLine + "Is Checked Out: " + IsCheckedOut.ToString() ;
            return result;
        }
    }
}
