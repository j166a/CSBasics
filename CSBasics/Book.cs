using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSBasics
{
    internal class Book
    {
        public string Title
        {
            get;
            set;
        }
        public int Pages
        {
            get;
            set;
        }
        public int CurrentPage
        {
            get;
            set;
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            CurrentPage = 1;
        }

        public void TurnPage()
        {
            if (doesPageExist())
            {
                CurrentPage++;
                Console.WriteLine($"The current page is {CurrentPage}");
            } else
            {
                Console.WriteLine("The new page does not exist!");
            }

               
        }

        private bool doesPageExist()
        {
            return CurrentPage <= Pages;
        }
    }
}
