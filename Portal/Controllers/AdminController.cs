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

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public ActionResult Index()
        {
            var viewModel = new List<AdminViewModel>();

            viewModel = (from user in _context.Users
                         join admin in _context.Admins on user.UserId equals admin.UserId into Details
                         from adminModel in Details.DefaultIfEmpty()
                         select new AdminViewModel
                         {
                             StaffName = user != null ? user.StaffName : string.Empty,
                             Gender = user != null ? user.Gender : string.Empty,
                             Division = user != null ? user.Division : string.Empty,
                             Level = user != null ? user.Level : string.Empty,
                             UserId = user != null ? user.UserId : default(int),
                             ServiceLength = adminModel != null? adminModel.ServiceLength : string.Empty,
                             MovingTo = adminModel != null ? adminModel.MovingTo : string.Empty,
                             AlumniHomeAddress = adminModel != null ? adminModel.AlumniHomeAddress : string.Empty,
                             AdminId= adminModel != null ? adminModel.AdminId : default(int)
                         }).ToList();
            return View(viewModel);
        }


        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Admins.Add(admin);
                _context.SaveChanges();
                return RedirectToAction("ThankYou");
            }

            return View(admin);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            var viewModel = new AdminViewModel();

            viewModel = (from user in _context.Users
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
                         }).Where(a => a.UserId == id).FirstOrDefault();
            return View(viewModel);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AdminViewModel model, int id)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    var viewmodel = new Admin
                    {
                        UserId= model.UserId,
                        ServiceLength= model.ServiceLength,
                        AlumniHomeAddress= model.AlumniHomeAddress,
                        MovingTo= model.MovingTo
                    };
                    _context.Admins.Add(viewmodel);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index), new {id= viewmodel.AdminId});
                }
            }
            catch (Exception ex)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(model);
        }

        public ActionResult ThankYou()
        {
            return View();
        }

    }
}
