using System;


namespace Labs
{
    class Pr2
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        //Task4 
        private static void Task4()
        {
            int[] X = new int[10 + 5];

            X[0] = 0;

            Console.Write("Enter the number M: ");
            int M = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 1; i < X.Length; i++)
            {
                X[i] = random.Next(-50, 50);
            }
            Console.WriteLine("Array X\n");
            PrintArr(X);

            int count = 0;
            foreach (int el in X)
            {
                if (Math.Abs(el) > M)
                {
                    count++;
                }
            }

            int[]Y = new int[count];
            int index = 0;
            foreach (int el in X)
            {
                if (Math.Abs(el)>M)
                {
                    Y[index] = el;
                    index++;
                }
            }

            Console.WriteLine("\nArray Y\n");
            PrintArr(Y);
        }

        static private void PrintArr(int[]arr)
        {
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        //------


        //Task3
        private static void Task3()
        {
            int[] X = new int[10 + 5];

            Random random = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = random.Next(-50, 50);
            }

            int min,max;
            min = X[0];
            max = X[1];

            foreach (int el in X)
            { 
                if (el < min)
                {
                    min = el;
                }
                if (el > max)
                {
                    max = el;
                }
            }

            foreach(int el in X)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine($"\nMin: {min}\nMax: {max}");
        }

        //Task2
        private static void Task2()
        {
            int side1 = 5, side2 = 5, side3 = 10;

            int perimeter = Perimeter(side1,side2, side3);
            double square = Square(side1,side2, side3);

            Console.WriteLine($"P: {perimeter}\nS: {square}");

            if (IsTriangleExist(side1,side2,side3))
            {
                if (side1 == side2 && side1 == side3)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Different sides");
                }
            }
            else
            {
                Console.WriteLine("Doesnt exist");
            }
 
        }
         
        private static bool IsTriangleExist(int side1, int side2, int side3)
        {
            return side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2;
        }
        private static int Perimeter(int side1, int side2, int side3) 
        {
            return side1 + side2 + side3;
        }
        private static double Square(int side1, int side2, int side3)
        {
            float p = (side1 + side2 + side3) / 2;
            double res = Math.Sqrt(p*(p+side1) * (p + side2) * (p + side3));

            return res;
        }
        // ------

        //Task1
        private static void Task1()
        {
            int[] arr = { 5, 15, 20 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int el in arr)
            {
                if (el >= 1 && el <= 10 + 5)
                {
                    Console.WriteLine($"Element {el} in range [1,15]");
                }
            }
        }

        
    }
}