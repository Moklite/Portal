using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Portal.Models;
using Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Portal.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context) => _context = context;

        public ActionResult Index() => View((from user in _context.Users
                                             join admin in _context.Admins on user.UserId equals admin.UserId into Details
                                             from adminModel in Details.DefaultIfEmpty()
                                             select new AdminViewModel
                                             {
                                                 StaffName = user != null ? user.StaffName : string.Empty,
                                                 Gender = user != null ? user.Gender : string.Empty,
                                                 Division = user != null ? user.Division : string.Empty,
                                                 Level = user != null ? user.Level : string.Empty,
                                                 UserId = user != null ? user.UserId : default(int),
                                                 ServiceLength = adminModel != null ? adminModel.ServiceLength : string.Empty,
                                                 MovingTo = adminModel != null ? adminModel.MovingTo : string.Empty,
                                                 AlumniHomeAddress = adminModel != null ? adminModel.AlumniHomeAddress : string.Empty,
                                                 AdminId = adminModel != null ? adminModel.AdminId : default(int)
                                             }).ToList());

        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin admin) => ModelState.IsValid ? RedirectToAction("ThankYou") : View(admin);

        public ActionResult Edit(int? id) => View((from user in _context.Users
                                                   join admin in _context.Admins on user.UserId equals admin.UserId into Details
                                                   from adminModel in Details.DefaultIfEmpty()
                                                   select new AdminViewModel
                                                   {
                                                       StaffName = user != null ? user.StaffName : string.Empty,
                                                       Gender = user != null ? user.Gender : string.Empty,
                                                       Division = user != null ? user.Division : string.Empty,
                                                       Level = user != null ? user.Level : string.Empty,
                                                       UserId = user != null ? user.UserId : default(int),
                                                       ServiceLength = adminModel != null ? adminModel.ServiceLength : string.Empty,
                                                       MovingTo = adminModel != null ? adminModel.MovingTo : string.Empty,
                                                       AlumniHomeAddress = adminModel != null ? adminModel.AlumniHomeAddress : string.Empty,
                                                       AdminId = adminModel != null ? adminModel.AdminId : default(int)
                                                   }).Where(a => a.UserId == id).FirstOrDefault());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Admins.Add(new Admin { UserId = model.UserId, ServiceLength = model.ServiceLength, AlumniHomeAddress = model.AlumniHomeAddress, MovingTo = model.MovingTo });
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public ActionResult ThankYou() => View();
    }

}
