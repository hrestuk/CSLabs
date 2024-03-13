using System;

namespace Pr3 
{
    class Pr3 
    {
        static void Main(string[] args)
        {
            ////Task 
            
            //Book book = new Book("title","author","content");
            
            //book.Show();

            //Task 2
            
            Console.WriteLine("Enter the number of sides(3-5)");
            int number = int.Parse(Console.ReadLine());

            Figure figure;
            if (number >= 3 && number <= 5)
            {
                figure = InitializeFigure(number);
                
                
                if (figure.IsFigurePossible())
                {
                    figure.PerimeterCalculator();
                }
                else
                {
                    Console.WriteLine("Figure isn't possible");
                }     
            }
            else
            {
                Console.WriteLine("Error");
            }
            

        }

        private static Figure InitializeFigure(int num)
        {
            switch (num) 
            { 
                case 3:
                {
                    Point A = new Point(0, 0, "A");
                    Point B = new Point(10, 0, "B");
                    Point C = new Point(16, 0, "C");

                    return new Figure(A,B,C);
                }
                case 4:
                {
                    Point A = new Point(0, 0, "A");
                    Point B = new Point(1, 0, "B");
                    Point C = new Point(4, 0, "C");
                    Point D = new Point(4, 3, "D");

                    return new Figure(A, B, C, D);
                        
                }
                case 5:
                {
                    Point A = new Point(0, 0, "A");
                    Point B = new Point(1, 0, "B");
                    Point C = new Point(3, 0, "C");
                    Point D = new Point(7, 0, "D");
                    Point E = new Point(5, 6, "E");

                    return new Figure(A, B, C, D, E);
                     
                }
                default:
                {
                    Console.WriteLine("Error");
                    return null;
                        
                }

            }
        }
    }
}