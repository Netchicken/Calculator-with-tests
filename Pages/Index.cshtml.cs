
using Calculator_with_tests.CalcOperations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator_with_tests.Pages
{

    public class IndexModel : PageModel
    {
        Operations operations = new Operations();

        [BindProperty(SupportsGet = true)] //SupportsGet sets the field data back into the page when the page reloads
        public string? num1 { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? num2 { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Answer { get; set; }
        [BindProperty]
        public string? ErrorMessage { get; set; }



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
                Answer = operations.Add(Num1, Num2);

            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }


        public PageResult OnPostSubtract(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                Answer = operations.Subtract(Num1, Num2);

            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }


        public PageResult OnPostDivide(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                Answer = operations.Divide(Num1, Num2);
            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }



        public PageResult OnPostMultiply(string Num1, string Num2)
        {
            //test that there are two numbers and the code works
            try
            {
                Answer = operations.Multiply(Num1, Num2);

            }
            catch (Exception e)
            { //catch if there is an error
                ErrorMessage = "You have an error which is ... " + e;
            }
            return Page();
        }


        public void OnGet()
        {

        }
        public void Onpost()
        {

        }


    }
}