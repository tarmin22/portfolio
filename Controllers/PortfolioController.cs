using Microsoft.AspNetCore.Mvc;
namespace portfolio
{
    public class PorfolioController : Controller
    {
        // Requests
        // localhost:5000
        [HttpGet("")]
        // Use [HttpPost]  for posting
        public string PortfolioController()
        {
            return "This is my index!";
        }

        // localhost:5000
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        //localhost:5000/user/???
        [HttpGet("contact")]
        public string contact()
        {
            return "This is my contact";
        }

    }
}