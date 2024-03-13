using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3.Parts
{
    class Title
    {
        private string content;

        public string Content
        {
            private get
            {
                if (content != null)
                {
                    return content;
                }
                else
                {
                    return "Header is missing";
                }
            } 
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: "+Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
