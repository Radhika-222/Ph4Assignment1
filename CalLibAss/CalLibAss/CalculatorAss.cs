namespace CalLibAss
{
    public class CalculatorAss
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Multiplication()
        {
            int res;
            res = num1 * num2;
            return res;
        }

        public int Subtraction()
        {
            int res;
            res = num1 - num2;
            return res;
        }

        public int Division()
        {
            int res;
            res = num1 / num2;
            return res;
        }

    }
}
