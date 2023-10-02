using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class Fun : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string message =
                "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Iusto, repellat. Libero rerum cumque voluptate soluta nemo officia numquam neque eveniet sunt tenetur nam beatae, eos similique autem obcaecati maiores. Neque.";
            return View("Index", message);
        }

        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {
            int[] numeros = { 1, 2, 3, 10, 43, 5 };
            return View(numeros);
        }

        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            List<User> users = new List<User>
            {
                new User("moose phillips"),
                new User("Sarah"),
                new User("Jerry"),
                new User("Rene Ricky"),
                new User("Barbarah")
            };
            return View("Users", users);
        }

        [HttpGet]
        [Route("user")]
        public IActionResult Getuser()
        {
            User user = new User("moose phillips");
            return View(user);
        }
    }
}
