public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            int num1 = 10;
            int num2 = 5;

            int sum = Sum(num1, num2);
            int diff = Difference(num1, num2);
            int product = Product(num1, num2);
            int quotient = Quotient(num1, num2);

            MessageBox.Show("Sum: " + sum);
            MessageBox.Show("Difference: " + diff);
            MessageBox.Show("Product: " + product);
            MessageBox.Show("Quotient: " + quotient);

            double num3 = 10.5;
            double num4 = 2.5;
            double sumDouble = SumDouble(num3, num4);

            MessageBox.Show("Sum of doubles: " + sumDouble);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Difference(int a, int b)
        {
            return a - b;
        }

        static int Product(int a, int b)
        {
            return a * b;
        }

        static int Quotient(int a, int b)
        {
            return a / b;
        }

        static double SumDouble(double a, double b)
        {
            return a + b;
        }
    }
