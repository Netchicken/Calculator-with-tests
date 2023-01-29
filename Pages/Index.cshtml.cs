
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator_with_tests.Pages
{

    public class IndexModel : PageModel
    {
        // private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)] //SupportsGet sets the field data back into the page when the page reloads
        public string? num1 { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? num2 { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Answer { get; set; }
        [BindProperty]
        public string? ErrorMessage { get; set; }

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel()
        {
        }

        //https://wellsb.com/csharp/aspnet/xunit-unit-test-razor-pages
        //https://www.learnrazorpages.com/razor-pages/handler-methods
        public PageResult OnPostAdd(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                Answer = Add(Num1, Num2);

            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }

        public string Add(string Num1, string Num2)
        {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 + num2;
            return (Num1 + " + " + Num2 + " = " + answer.ToString()); //send back the answer
        }

        public PageResult OnPostSubtract(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                Answer = Subtract(Num1, Num2);

            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }

        public string Subtract(string Num1, string Num2)
        {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 - num2;
            return num1.ToString() + " - " + num2.ToString() + " = " + answer.ToString();
        }

        public PageResult OnPostDivide(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                Answer = Divide(Num1, Num2);
            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }

        public string Divide(string Num1, string Num2)
        {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 / num2;
            return (Num1 + " / " + Num2 + " = " + answer.ToString()); //send back the answer
        }

        public PageResult OnPostMultiply(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                Answer = Multiply(Num1, Num2);

            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }

        public string Multiply(string Num1, string Num2)
        {
            float num1 = Convert.ToSingle(Num1);
            float num2 = Convert.ToSingle(Num2);
            float answer = num1 * num2;
            return (Num1 + " * " + Num2 + " = " + answer.ToString()); //send back the answer
        }

        public void OnGet()
        {

        }
        public void Onpost()
        {

        }


    }
}