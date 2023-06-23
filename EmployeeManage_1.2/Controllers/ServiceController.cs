using EmployeeManage_1._2.Interface;
using EmployeeManage_1._2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManage_1._2.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServices services;

        public ServiceController(IServices services)
        {
            this.services = services;
        }

        public IActionResult Index()
           {
            try
            {
                string myValue = services.GetValue("MySettingKey");
               // var view = new ServiceVM { SettingValue = myValue };
               // return View();
              // return Content(myValue);
              return View("Index",myValue);
            }
            catch (Exception ex)
            {
                
                return RedirectToAction("Error", "Index");
            }
        }
    }
}
