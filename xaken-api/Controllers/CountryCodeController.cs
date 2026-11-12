using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace xaken_api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CountryCodeInterface {
        public string name { get; set; }
        public string dial_code { get; set; }
        public string code { get; set; }
    }

    public class CountryCodeController : ControllerBase
    {
        private static readonly countryCodeList<CountryCodeInterface> = []
        { 
            
        };
    }
}
