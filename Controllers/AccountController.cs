using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Web_System.Models;
using Web_System.Data;
using System.Linq;

namespace Web_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly SystemContext _context;

        public AccountController(SystemContext context)
        {
            _context = context;
        }
        
        public IActionResult Login()
        {
            return View();
        }
        public ActionResult Validate(Admins admin)
        {
            var _admin = _context.Admins.Where(s => s.Email == admin.Email);
            if(_admin.Any()){
                if(_admin.Where(s => s.Password == admin.Password).Any()){
                    
                    return Json(new { status = true, message = "Login Successfull!"});
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!"});
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!"});
            }
        }
    }
}

