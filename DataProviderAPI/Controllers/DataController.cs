using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataProviderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> data = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                data.Add(new Random().Next().ToString());
            }
            return data;
        }
    }
}
