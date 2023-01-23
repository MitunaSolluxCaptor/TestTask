using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using TestTask.Models;
using System.Net;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));
            ValCurs? val;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            WebClient web = new WebClient();
            using (Stream data = web.OpenRead("http://www.cbr.ru/scripts/XML_daily.asp"))
            {
                using (StreamReader reader = new StreamReader(data, Encoding.GetEncoding(1251)))
                {
                    string html = reader.ReadLine();
                    using (TextReader textReader = new StringReader(html))
                    {
                        val = xmlSerializer.Deserialize(textReader) as ValCurs;
                    }
                }
            }
            ViewData["Date"] = val.Date;
            ViewData["USD"] = val.Valute.Where(V => V.ID == "R01235").FirstOrDefault().Value;
            ViewData["EUR"] = val.Valute.Where(V => V.ID == "R01239").FirstOrDefault().Value;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult TaskOne()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Rec(Rec rec)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Rec()
        {
            return View();
        }
    }
}
