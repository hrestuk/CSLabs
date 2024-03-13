using Pr3.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    public class Book
    {
        private Title title;
        private Author author;
        private Body body;

        
        public Book()
        {
            Initialization();

            Console.Write("Enter the title: ");
            title.Content = Console.ReadLine();

            Console.Write("Enter the author: ");
            author.Content = Console.ReadLine();

            Console.Write("Enter the content: ");
            body.Content = Console.ReadLine();
        }
        public Book(string bookTitle, string bookAuthor, string bookBody) 
        {
            Initialization();

            title.Content = bookTitle;
            author.Content = bookAuthor;
            body.Content = bookBody;
        }

        private void Initialization()
        {
            title = new Title();
            author = new Author();
            body = new Body();
        }

        public void Show()
        {
            title.Show();
            author.Show();
            body.Show();
        }

    }
}
