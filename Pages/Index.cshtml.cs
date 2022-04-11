﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator_with_tests.Pages
{

    public class IndexModel : PageModel
    {
        // private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)] //SupportsGet sets the field data when the page reloads
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
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);
                float answer = num1 + num2;
                Answer = (Num1 + " + " + Num2 + " = " + answer.ToString()); //send back the answer

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
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);
                float answer = num1 - num2;
                Answer = num1.ToString() + " - " + num2.ToString() + " = " + answer.ToString();

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
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);
                float answer = num1 / num2;
                Answer = (Num2 + " / " + Num1 + " = " + answer.ToString()); //send back the answer
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
                float num1 = Convert.ToSingle(Num1);
                float num2 = Convert.ToSingle(Num2);
                float answer = num1 * num2;
                Answer = (Num1 + " * " + Num2 + " = " + answer.ToString()); //send back the answer

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