using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32.SafeHandles;
using OBSBusiness.DTO;
using OBSBusiness.Manager;
using OBSEntity.Entities;
using OBSUI.Models;
using System.Diagnostics;

namespace OBSUI.Controllers
{
    public class HomeController : Controller
    {
        public StudentManager _studentManager = new StudentManager();
        private SafeFileHandle path;
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            List<StudentEntity> studentForViewBag = _studentManager.GetListStudent();
            ViewBag.students = studentForViewBag;
            return View();
        }

        [HttpPost]
        public ActionResult Add(StudentAddDto students)
        {
            _studentManager.AddStudent(students);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult GetStudentById(int id)
        {
            StudentEntity students = _studentManager.GetStudent(id);
            JsonResult studentEn = Json(students);
            return studentEn;
        }

        public ActionResult Delete(int id)
        {
            _studentManager.DeleteProducut(id);
            return RedirectToAction("Index");
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
    }
}