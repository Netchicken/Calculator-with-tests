namespace Calculator_with_tests.CalcOperations
{
    public class Operations
    {


        public string Add(string Num1, string Num2)
        {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 + num2;
            return (Num1 + " + " + Num2 + " = " + answer.ToString()); //send back the answer
        }


        public string Subtract(string Num1, string Num2)
        {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 - num2;
            return num1.ToString() + " - " + num2.ToString() + " = " + answer.ToString();
        }


        public string Divide(string Num1, string Num2)
        {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 / num2;
            return (Num1 + " / " + Num2 + " = " + answer.ToString()); //send back the answer
        }



        public string Multiply(string Num1, string Num2)
        {
            float num1;
            float num2;
            float answer;

            try
            {
                num1 = Convert.ToSingle(Num1);
                num2 = Convert.ToSingle(Num2);
                answer = num1 * num2;
            }
            catch (Exception)
            {

                return "Error";
            }


            return (Num1 + " * " + Num2 + " = " + answer.ToString()); //send back the answer
        }






    }
}
