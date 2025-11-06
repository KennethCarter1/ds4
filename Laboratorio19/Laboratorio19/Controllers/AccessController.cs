using Laboratorio19.Models.WS;
using System.Web.Http;

namespace Laboratorio191.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply HelloWorld()
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.data = null;
            oR.message = "Mi Hello World en API";
            return oR;
        }
    }
}