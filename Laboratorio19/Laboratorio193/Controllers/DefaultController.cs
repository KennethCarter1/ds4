using System;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace Laboratorio192.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        // Obtener todos los elementos (Laboratorio 19-2)
        public string GetItems()
        {
            var url = "https://localhost:44349/api/Values/Get/2";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return "Error: No response";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}