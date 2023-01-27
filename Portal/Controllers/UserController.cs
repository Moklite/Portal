using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Models;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Portal.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index() => View();

        public ActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(User model)
        {
            try
            {
                _context.Users.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UserExperience), new { id = model.UserId });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "unable to run command check in with the admin");
            }
            return View(model);
        }

        [HttpGet("User/UserExperience/{id}")]
        public ActionResult UserExperience(int? id)
        {
            var check = _context.Users.FirstOrDefault(x => x.UserId == id);
            if (check == null) return NotFound();
            return View("UserExperience", check);
        }

        [HttpPost("User/Experience")]
        public ActionResult UserExperience(User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return RedirectToAction("ThankYou");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "unable to run command check in with the admin");
            }
            return View(user);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var model = await _context.Users.FindAsync(id);
                _context.Users.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "unable to run command check in with the admin");
            }
            return RedirectToAction("Index");
        }

        public ActionResult ThankYou() => View();
    }


}
