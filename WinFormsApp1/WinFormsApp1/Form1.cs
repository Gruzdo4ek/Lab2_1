namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chA.Text = Properties.Settings.Default.a.ToString();
            chB.Text = Properties.Settings.Default.b.ToString();
            chC.Text = Properties.Settings.Default.c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int a = int.Parse(this.chA.Text);
                int b = int.Parse(this.chB.Text);
                int c = int.Parse(this.chC.Text);

                Properties.Settings.Default.a = a;
                Properties.Settings.Default.b= b;
                Properties.Settings.Default.c = c;
                Properties.Settings.Default.Save();

                MessageBox.Show(Logic.Results(a,b,c));
            }
            catch(FormatException)
            {
                MessageBox.Show("Неккоректный ввод","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
        }
    }
    public class Logic
    {
        public static bool CheckAllEqual(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return true;
            }
            return false;
        }
        public static bool CheckTwoEqual(int a, int b, int c)
        {
            if ((a == b && b != c) || (a == c && a != b) || (b == c && b != a))
            {
                return true;
            }
            return false;
        }

        public static (int, int) FindMinMax(int a, int b, int c)
        {
            int min = a, max = a;

            if (b < min)
                min = b;
            else if (b > max)
                max = b;

            if (c < min)
                min = c;
            else if (c > max)
                max = c;

            return (min, max);
        }

        public static int FindMiddle(int a, int b, int c)
        {
            (int max, int min) = FindMinMax(a, b, c);

            if ((b < max && max < c) || (c < max && max < b))
            {
                return max;
            }
            else if ((max < b && b < min) || (min < b && b < max))
            {
                return b;
            }
            else
            {
                return min;
            }
        }

        public static (int, int, int) All(int a, int b, int c)
        {
            (int min, int max) = Logic.FindMinMax(a, b, c);
            int middle = Logic.FindMiddle(a, b, c);
            return (min, middle, max);
        }
        public static string Results(int a, int b, int c)

        {
            string outMessage = "";
            if (Logic.CheckAllEqual(a, b, c))
            {
                outMessage = "Числа равны.";

            }
            else if (Logic.CheckTwoEqual(a, b, c))
            {
                (int min, int middle, int max) = Logic.All(a, b, c);
                outMessage =
                    $"Самое большое число: {max}" +
                    $"\nСамое маленькое число: {min}";
            }
            else
            {
                (int min, int middle, int max) = Logic.All(a, b, c);

                outMessage =
                    $"Самое большое число: {max}" +
                    $"\nСамое маленькое число: {min}" +
                    $"\nСреднее число: {middle}";

            }
            return outMessage;
        }
    }
}