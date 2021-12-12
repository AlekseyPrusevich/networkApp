using Microsoft.AspNetCore.Mvc;

namespace networkApp.Controllers
{
    public class LectureController : Controller
    {
        public static string _fileName;

        public IActionResult Index(string path)
        {
            _fileName = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(path));
            _fileName = _fileName.Replace(".cshtml", "");

            return View(_fileName);
        }
    }
}
