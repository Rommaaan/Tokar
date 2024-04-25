public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Функция возведения в квадрат разности двух целых чисел
            int num1 = 10;
            int num2 = 5;
            int squareDifference = SquareDifference(num1, num2);
            MessageBox.Show("Square of Difference: " + squareDifference);

            // Функция возведения в квадрат произведения двух целых чисел
            int squareProduct = SquareProduct(num1, num2);
            MessageBox.Show("Square of Product: " + squareProduct);

            // Функция возведения в квадрат частного двух целых чисел
            int squareQuotient = SquareQuotient(num1, num2);
            MessageBox.Show("Square of Quotient: " + squareQuotient);

            // Функция возведения в квадрат суммы двух вещественных чисел
            double num3 = 3.5;
            double num4 = 2.8;
            double squareSumOfDoubles = SquareSumOfDoubles(num3, num4);
            MessageBox.Show("Square of Sum of Doubles: " + squareSumOfDoubles);

            // Функция возведения в квадрат разности двух вещественных чисел
            double squareDifferenceOfDoubles = SquareDifferenceOfDoubles(num3, num4);
            MessageBox.Show("Square of Difference of Doubles: " + squareDifferenceOfDoubles);
        }

        static int SquareDifference(int a, int b)
        {
            int difference = a - b;
            return difference * difference;
        }

        static int SquareProduct(int a, int b)
        {
            int product = a * b;
            return product * product;
        }

        static int SquareQuotient(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed");
                return 0;
            }
            int quotient = a / b;
            return quotient * quotient;
        }

        static double SquareSumOfDoubles(double a, double b)
        {
            double sum = a + b;
            return sum * sum;
        }

        static double SquareDifferenceOfDoubles(double a, double b)
        {
            double difference = a - b;
            return difference * difference;
        }
    }
