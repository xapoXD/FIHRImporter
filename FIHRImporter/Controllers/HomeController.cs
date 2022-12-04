using FIHRImporter.Models;
using javax.jws;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using System.Diagnostics;


namespace FIHRImporter.Controllers
{

    public class HomeController : Controller
    {
/*
        public class TextBoxValue
        {
            [Required(ErrorMessage = "Value is required")]
            public string firstname { get; set; }
        }

        TextBoxValue textbox = new TextBoxValue();
        public IActionResult Index()
        {
            textbox.firstname = "John";
            return View(textbox);
        }

        [HttpPost]
        public IActionResult Index(TextBoxValue model)
        {
            textbox.firstname = model.firstname;
            return View(textbox);
        }

        */


        /*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        //------------------------------------------------                   -------
        private readonly IHttpContextAccessor contxt;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            contxt = httpContextAccessor;

        }

        private int var1 = 50;

        public int Coins { get; set; } = 0; 

  
        public IActionResult Index()
        {
            var1 += 10;
            contxt.HttpContext.Session.SetInt32("Coins", Coins);
            contxt.HttpContext.Session.SetInt32("StudentId", var1);
            contxt.HttpContext.Session.SetString("StudentName", "Pablo");
            


            


            return View();
        }


        public void OnPostPage4back()
        {
            Console.WriteLine("PABLO UDELAL +1");

            var1++;
            contxt.HttpContext.Session.SetInt32("StudentId", var1);
        }








        [JSInvokable]
        public static void CSCallBackMethod()
        {
            Console.WriteLine("C# Method invoked");
        }





        [HttpPost]
            public void IncrementCount()
            {
                // 
            }



        



        public bool showCriteria;

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCriteria(int number = 1)
        {
            number += 1;
            showCriteria = true;
            return RedirectToAction("JudgeCriteria", new { criteriaNo = number });
        }


        public ActionResult JudgeCriteria(int criteriaNo)
        {
            ViewData["ShowCriteria"] = showCriteria;
            ViewData["criteriaNo"] = criteriaNo;
            Console.WriteLine(criteriaNo);
            return View();
        }





















        public int num;
        public void doSomething(object sender, EventArgs e)
        {
            int someOtherNum = 10 + num;
        }



        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var1 += 10;
            contxt.HttpContext.Session.SetInt32("StudentId",var1);
            //Session["var1"] = var1; // cache var1
            //lblvar1.Text = var1.ToString();
        }



        //----------------------------

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





        



















    }
}