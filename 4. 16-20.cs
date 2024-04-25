public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Функция возведения в квадрат произведения двух вещественных чисел
            double num1 = 3.5;
            double num2 = 2.8;
            double squareProductOfDoubles = SquareProductOfDoubles(num1, num2);
            MessageBox.Show("Square of Product of Doubles: " + squareProductOfDoubles);

            // Функция возведения в квадрат частного двух вещественных чисел
            double squareQuotientOfDoubles = SquareQuotientOfDoubles(num1, num2);
            MessageBox.Show("Square of Quotient of Doubles: " + squareQuotientOfDoubles);

            // Функция возведения в куб целого числа
            int num3 = 4;
            int cubeNumber = CubeNumber(num3);
            MessageBox.Show("Cube of Number: " + cubeNumber);

            // Функция возведения в куб суммы двух целых чисел
            int num4 = 5;
            int cubeSumOfIntegers = CubeSumOfIntegers(num3, num4);
            MessageBox.Show("Cube of Sum of Integers: " + cubeSumOfIntegers);

            // Функция возведения в куб разности двух целых чисел
            int cubeDifferenceOfIntegers = CubeDifferenceOfIntegers(num3, num4);
            MessageBox.Show("Cube of Difference of Integers: " + cubeDifferenceOfIntegers);
        }

        static double SquareProductOfDoubles(double a, double b)
        {
            double product = a * b;
            return product * product;
        }

        static double SquareQuotientOfDoubles(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed");
                return 0;
            }
            double quotient = a / b;
            return quotient * quotient;
        }

        static int CubeNumber(int a)
        {
            return a * a * a;
        }

        static int CubeSumOfIntegers(int a, int b)
        {
            return (a + b) * (a + b) * (a + b);
        }

        static int CubeDifferenceOfIntegers(int a, int b)
        {
            return (a - b) * (a - b) * (a - b);
        }
    }
