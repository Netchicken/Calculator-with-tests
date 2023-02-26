using Calculator_with_tests.Model;

namespace Calculator_with_tests.CalcOperations {
    public class Operations {
        public string Add(string Num1, string Num2) {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 + num2;
            return (Num1 + " + " + Num2 + " = " + answer.ToString()); //send back the answer
        }
        public string Subtract(string Num1, string Num2) {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 - num2;
            return num1.ToString() + " - " + num2.ToString() + " = " + answer.ToString();
        }
        public string Divide(string Num1, string Num2) {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 / num2;
            return (Num1 + " / " + Num2 + " = " + answer.ToString()); //send back the answer
        }
        public string Multiply(string Num1, string Num2) {
            float num1;
            float num2;
            float answer;

            try {
                num1 = Convert.ToSingle(Num1);
                num2 = Convert.ToSingle(Num2);
                answer = num1 * num2;
            }
            catch (Exception) {

                return "Error";
            }
            return (Num1 + " * " + Num2 + " = " + answer.ToString()); //send back the answer
        }

        public bool IsNumberOdd(int value) {
            //return true if you can divide the value by 2 and get a remainder of 1
            return value % 2 == 1;
        }


        public Double AddTheory(double x, double y) {
            return x + y;
        }

        public double AddClassFact(CalcData calcData) {

            calcData.Answer = calcData.num1 + calcData.num2;
            return calcData.Answer;
        }

    }
}
