using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThePowerRanges.Models;

namespace ThePowerRanges.Controllers
{
    public class UsersController : Controller
    {
        private readonly DBContext _context;

        public UsersController(DBContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Surname,Email,PhoneNumber,Password,ConfirmPassword,DateOfBirth,AccountType")] UserReadModel userReadModel)
        {
            if (ModelState.IsValid)
            {
                //password check here
                var passwordValid = userReadModel.Password==userReadModel.ConfirmPassword ;
                if (passwordValid == true)
                {

                    var myUser = new User();
                    myUser.Name = userReadModel.Name;
                    myUser.Surname = userReadModel.Surname;
                    myUser.Email = userReadModel.Email;
                    myUser.PhoneNumber = userReadModel.PhoneNumber;
                    myUser.Password = userReadModel.Password;
                    myUser.DateOfBirth = userReadModel.DateOfBirth;
                    myUser.AccountType = userReadModel.AccountType;

                    _context.Add(myUser);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
                
               
            }
            return View();
        }


        //login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email,Password")] UserLoginReadModel loginReadModel)
        {
            var myUser = _context.User.FirstOrDefault(u => u.Email == loginReadModel.Email);
           
            if (myUser != null && myUser.Password == loginReadModel.Password)
                {

                 var userId = myUser.Id;
                 HttpContext.Session.SetString("UserId", myUser.Id.ToString());
                 HttpContext.Session.SetString("UserEmail", myUser.Email.ToString());

                 return RedirectToAction(nameof(Dashboard));

            }
            ModelState.Clear();
            ModelState.AddModelError("ErrorMessage","Incorrect Email or Password");
            

            return View();


        }

        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Email,PhoneNumber,Password,DateOfBirth,AccountType")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
