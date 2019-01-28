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
            Console.ReadKey();

            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey();

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadKey();

            int n4 = 5;
            printTriangle(n4);

            Console.ReadKey();

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment

        }

        public static Boolean isPrime(int num)
        {
            if (num == 2)
                return true;
            if (num < 2 || num % 2 == 0)
                return false;
            for (int i = 3; i * i <= num; i += 2)
                if (num % i == 0)
                    return false;
            return true;
        }

        public static void printPrimeNumbers(int x, int y)
        {
            //int n = 0;
            try
            {
                for (int i = x; i <= y; i++)
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

        public static double fact(int n)
        {
            double f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }


        public static double getSeriesResult(int n)
        {
            try
            {
                double even = 0;
                double odd = 0;
                for (int i = 1; i <= n; i = i + 2)
                {
                    double result1 = fact(i) / (i + 1);
                    even = even + result1;
                }
                for (int i = 2; i <= n; i = i + 2)
                {
                    double result2 = fact(i) / (i + 1);
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

        public static long decimalToBinary(long n)
        {

            long rem = 0;
            long num = n; int count = 0;
            String a = "";
            try
            {
                while (num > 0)
                {
                    rem = num % 2;
                    if (rem == 1)
                    {
                        count++;
                    }
                    a = a + "" + rem;
                    num = num / 2;
                }
                long p = Convert.ToInt64(a);
                return p;
            }
            catch
            {
                Console.WriteLine("exception occured while computing decimaltobinary()");
            }

            return 0;
            }
            public static int calc(long n)
            {
                long var = 0;
                int val = 0;
                try
                {
                    var = 2 ^ n;
                    val = Convert.ToInt32(var);
                }
                catch { }
                return val;
            }

            public static long binaryToDecimal(long n)
            {
                int pow = 1;
                int val = 0;
                string num1 = n.ToString();
                try
                {
                    for (int i = num1.Length - 1; i >= 0; i--)
                    {
                        if (num1[i] == '1')
                        {
                            val += pow;
                        }
                        pow *= 2;
                    }
                    long var = Convert.ToInt64(val);
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

            public static void computeFrequency(int[] a)
        {
            try
            {
                int len = a.Length;
                int i, j, count;
                int[] freq = new int[len];
                for (i = 0; i < len; i++)
                {
                    freq[i] = -1;
                }


                for (i = 0; i < len; i++)
                {
                    count = 1;
                    for (j = i + 1; j < len; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                            freq[j] = 0;
                        }
                    }

                    if (freq[i] != 0)
                    {
                        freq[i] = count;
                    }

                }

                Console.Write("The frequency of each element in the array is as follows: \n");
                Console.Write("Number \t Frequency \n");
                for (i = 0; i < len; i++)
                {
                    if (freq[i] != 0)
                    {
                        Console.Write(a[i] + "\t" + freq[i] + "\n");
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


