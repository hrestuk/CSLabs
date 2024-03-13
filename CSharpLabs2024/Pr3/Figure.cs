using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    class Figure
    {
        private Point[] points;
        public Figure(Point A,Point B,Point C) 
        {
            points = new [] { A, B, C };  
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            points = new[] { A, B, C , D};  
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points = new[] { A, B, C, D, E};
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += CalculateSide(i);
            }

            perimeter += LengthSide(points[points.Length - 1], points[0]);
            Console.WriteLine($"Perimeter of {points.Length}-sided figure: {perimeter}");
        }
        
        public double CalculateSide(int i)
        {
            if (points.Length-1 == i)
            {
                return LengthSide(points[points.Length-1], points[0]);
            }
            else
            {
                return LengthSide(points[i], points[i + 1]);
            }
        }

        public bool IsFigurePossible()
        { 
            switch (points.Length)
            {
                case 3:
                {
                    double side1 = CalculateSide(0);
                    double side2 = CalculateSide(1);
                    double side3 = CalculateSide(2);
                    Console.WriteLine($"{side1} {side2} {side3}"); // for test

                    if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                case 4:
                {
                    double side1 = CalculateSide(0);
                    double side2 = CalculateSide(1);
                    double side3 = CalculateSide(2);
                    double side4 = CalculateSide(3);

                    //double side1 = 1; //test
                    //double side2 = 3;
                    //double side3 = 5;
                    //double side4 = 10;
                        
                    Console.WriteLine($"{side1} {side2} {side3} {side4}"); //for test

                    if ((side1 + side2 + side3 > side4) &&
                        (side2 + side3 + side4 > side1) &&
                        (side3 + side4 + side1 > side2) &&
                        (side4 + side1 + side2 > side3))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                case 5:
                {
                    double side1 = CalculateSide(0);
                    double side2 = CalculateSide(1);
                    double side3 = CalculateSide(2);
                    double side4 = CalculateSide(3);
                    double side5 = CalculateSide(4);

                    //double side1 = 1; //test
                    //double side2 = 2;
                    //double side3 = 3;
                    //double side4 = 4;
                    //double side5 = 11;

                    Console.WriteLine($"{side1} {side2} {side3} {side4} {side5}"); //for test

                    if ((side1 + side2 + side3 > side4) &&
                        (side2 + side3 + side4 > side5) &&
                        (side3 + side4 + side5 > side1) &&
                        (side4 + side5 + side1 > side2) &&
                        (side5 + side1 + side2 > side3))
                        {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                default:
                {
                    return false;
                }
            }
        }
    }
}
