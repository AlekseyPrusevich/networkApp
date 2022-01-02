using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using networkApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace networkApp.Controllers
{
    //[Authorize(Roles = "admin, teacher")]
    public class LectureConstructorController : Controller
    {
        public ApplicationContext Context { get; }

        public LectureConstructorController(ApplicationContext context)
        {
            Context = context;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CopyLecture(string fileName)
        {
            System.IO.File.Copy(@"Views\Lecture\" + fileName, @"Views\Lecture\" + fileName.Replace("_", " ").Replace(".cshtml", "") + " - Копия.cshtml");

            return View("EditList");
        }

        [HttpPost]
        public ActionResult EditLecture(string fileName)
        {
            StreamReader f = new StreamReader(@"Views\Lecture\"+ fileName);

            string lecture = f.ReadToEnd();
            f.Close();

            ViewData["FileName"] = fileName.Replace("_", " ").Replace(".cshtml", "");

            ViewBag.Lecture = lecture;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> DeleteLecture(string fileName)
        {
            await deleteLectureAsync(fileName);

            return View("EditList");
        }

        [HttpPost]
        public async Task<IActionResult> PushDocument(string lectureName, string oldName,  string myDoc)
        {
            System.IO.File.Delete(@"Views\Lecture\" + oldName.Replace(" ", "_") + ".cshtml");
            System.IO.File.Delete(@"Views\Lecture\" + lectureName.Replace(" ", "_") + ".cshtml");
            await createLectureAsync(lectureName, myDoc);

            return RedirectToAction("Index", "Home");
        }

        private async Task createLectureAsync(string _lectureName, string _myDoc)
        {
            string path = @"Views\Lecture\";

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (FileStream fstream = new FileStream($"{path}"+ _lectureName.Replace(" ", "_") + ".cshtml", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(_myDoc);
                fstream.Write(array, 0, array.Length);
            }

            await Context.SaveChangesAsync();
        }

        private async Task deleteLectureAsync(string fileName)
        {
            var isFileExist = System.IO.File.Exists(@"Views\Lecture\" + fileName);

            if (isFileExist)
            {
                System.IO.File.Delete(@"Views\Lecture\" + fileName);
            }

            await Context.SaveChangesAsync();
        }

    }
}
