using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        [Route("")]
        public string Phone ()
        {
            return "1+555+555+555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
