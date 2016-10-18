using System.Web.Http;

namespace MyWebApp.Controllers
{
    [RoutePrefix("api/test")]
    public class HealthController : ApiController
    {
        [HttpGet]
        [Route("{id:int}")]
        public string Get(int id)
        {
            return $"Your number is {id}";
        }
    }
}