
using Calculator_with_tests.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator_with_tests.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string num1 { get; set; }
        public string num2 { get; set; }
        public string answer { get; set; }
        public string answerReturn { get; set; }

        [BindProperty]
        public Answer Answer { get; set; }
        public IList<string> Answers { get; set; }
        public string ErrorMessage { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        //public IndexModel()
        //{
        //    IList<string> Answers = new List<string>();
        //}

        //https://www.learnrazorpages.com/razor-pages/handler-methods
        public RedirectToPageResult OnPostAdd(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);

                float answer = num1 + num2;

                Answer.Text = (Num1 + " + " + Num2 + " = " + answer); //send back the answer
            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;

            }

            return RedirectToPage();
        }

        public RedirectToPageResult OnPostSubtract(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);

                float answer = num1 - num2;
                string text = num1.ToString() + " - " + num2.ToString() + " = " + answer.ToString();

                Answer.Text = (text);
            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return RedirectToPage();
        }

        public RedirectToPageResult OnPostDivide(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);

                float answer = num1 / num2;

                Answer.Text = (Num2 + " / " + Num1 + " = " + answer); //send back the answer
            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return RedirectToPage();
        }

        public RedirectToPageResult OnPostMultiply(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);

                float answer = num1 * num2;

                Answer.Text = (Num1 + " + " + Num2 + " = " + answer); //send back the answer
            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return RedirectToPage();
        }

        public void OnGet()
        {




        }
    }
}