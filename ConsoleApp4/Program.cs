using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);


            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            

            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("binary conversion of the decimal number " + n2 + " is: " + r2);
           

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            

            int n4 = 5;
            printTriangle(n4);

          
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadKey();
           
            // Doing this assignment helped me learn and revise the basic looping constructs, helped me learn to build the logic for the methods 

        }

        public static Boolean isPrime(int n) // method to calculate whether the number is prime or not
        {
            if (n == 2)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            for (int i = 3; i * i <= n; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static void printPrimeNumbers(int x, int y) //method to print the prime numbers
        {
            
            try
            {
                for (int i = x; i <= y; i++) //to print the prime numbers between x and y
                {

                    if (isPrime(i))
                    {
                        Console.WriteLine(+i + "\t");
                    }

                }
            }
            catch
            {
                Console.WriteLine("exception occured while computing printprimenumbers()");
            }
        }

        public static double fact(int n) //method to compute the factorial
        {
            double f = 1;
            for (int i = 1; i <= n; i++) //to calculate the factorial
            {
                f = f * i;
            }
            return f;
        }


        public static double getSeriesResult(int n) //to compute the series
        {
            try
            {
                double even = 0;
                double odd = 0;
                for (int i = 1; i <= n; i = i + 2)
                {
                    double result1 = fact(i) / (i + 1); //calling the method factorial to compute
                    even = even + result1;
                   
                }
                for (int i = 2; i <= n; i = i + 2)
                {
                    double result2 = fact(i) / (i + 1); //calling the method factorial to compute 
                    odd = odd + result2;
                   
                }
                double result = even - odd;

                return Math.Round(result, 3);
                

            }
            catch
            {
                Console.WriteLine("exception occured while computing getseriesresult()");
            }

            return 0;
        }

        public static long decimalToBinary(long n) //method to convert decimal to binary
        {

            long rem = 0;
            long num = n; 
            String a = "";
            try
            {
                while (num > 0)
                {
                    rem = num % 2; 
                    if (rem == 1)
                   
                    a = a + "" + rem; //to append remainder value in each iteration
                    num = num / 2;   //obtain quotient to reiterate
                }
                long p = Convert.ToInt64(a); //Typecasting 
                return p;
            }
            catch
            {
                Console.WriteLine("exception occured while computing decimaltobinary()");
            }

            return 0;
            }

            public static long binaryToDecimal(long n) //method to convert binary to decimal
            {
                int pow = 1;
                int val = 0;
                string num1 = n.ToString();
                try
                {
                    for (int i = num1.Length - 1; i >= 0; i--) //compute power of 2
                    {
                        if (num1[i] == '1') 
                        {
                            val =val+pow;
                        }
                        pow = pow*2;
                    }
                    long var = Convert.ToInt64(val); //typecasting
                    return var;
                }
                catch
                {
                    Console.WriteLine("exception occured while computing binarytodecimal()");
                }

                    return 0;
                }

            public static void printTriangle(int n)
            {
                try
                {
                    for (int i = 1; i <= n; i++)
                    {

                         
                        for (int j = n; j >= i; j--)  // to print number of spaces
                        {
                            Console.Write(" ");
                        }

                         
                        for (int j = 1; j <= i; j++) // to print the stars in each row
                    {
                            Console.Write("* ");
                        }

                        
                        Console.WriteLine(); // for new line after printing each row of stars
                    Console.ReadKey();
                    }
                }

                catch
                {
                    Console.WriteLine("exception occured while computing printtriangle()");
                }
            }

            public static void computeFrequency(int[] a) //method to compute the frequency 
           {
            try
            {
                //int len = a.Length;
                int i, j, count;
                int[] f = new int[a.Length]; 
                for (i = 0; i < a.Length; i++) 
                {
                    f[i] = -1;
                }


                for (i = 0; i < a.Length; i++)
                {
                    count = 1;
                    for (j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j]) //incrementing the frequency of a number
                        {
                            count++;
                            f[j] = 0;
                        }
                    }

                    if (f[i] != 0)
                    {
                        f[i] = count;
                    }

                }

                Console.Write("The frequency of the element: \n");
                Console.Write("Number \t Frequency \n");
                for (i = 0; i < a.Length; i++)
                {
                    if (f[i] != 0)
                    {
                        Console.Write(a[i] + "\t" + f[i] + "\n");
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }

        }
    }
}


