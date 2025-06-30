using Microsoft.AspNetCore.Mvc;
using CarRentalApp.Models;
using Microsoft.VisualBasic;
using System;
namespace CarRentalApp.Controllers
{
    public class CarAppController : Controller
    {
        carDBContext ob = new carDBContext();
        public IActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Customer c)
        {
            var res=(from t in ob.Customers
                    where t.Username == c.Username && t.Pwd == c.Pwd
                    select t).FirstOrDefault();
            if (res != null)
            {
                HttpContext.Session.SetString("CustomerId",res.CustomerId.ToString());
                return RedirectToAction("Viewcars");
            }
            else
            {
                ViewData["err"]= "Invalid Username or Password";
                return RedirectToAction("Register");
            }
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(Customer c)
        {
            if (ModelState.IsValid)
            {
                ob.Customers.Add(c);
                ob.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Viewcars(string search)
        {
            var res = from t in ob.Vehicles
                      select t;
            HttpContext.Session.SetString("uid", "");
            string st = HttpContext.Session.GetString("uid");

            if (!string.IsNullOrEmpty(search))
            {
                res = res.Where(v => v.Brand.Contains(search) || v.Model.Contains(search));
            }

            return View(res.ToList());
        }
         

        [HttpGet]
        public IActionResult RentCar(int VehicleId, String sat)
        {
            TempData["vehid"] = VehicleId;
            TempData["status"] = sat;
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public IActionResult RentCar(Rental r,DateOnly endt,DateOnly stdt)
        {
            Rental rob = new Rental();
            int id = Convert.ToInt32(HttpContext.Session.GetString("CustomerId"));
            rob.CustomerId = Convert.ToInt32(HttpContext.Session.GetString("CustomerId"));
            rob.VehicleId = Convert.ToInt32(TempData["vehid"]);
           
            {
                rob.Status = "Ongoing";
            }

            rob.StartDate = r.StartDate;
            rob.EndDate = r.EndDate;
            ob.Rentals.Add(rob);
            int i = ob.SaveChanges();
            int rid = (from t in ob.Rentals where t.VehicleId == Convert.ToInt32(TempData["vehid"]) && t.CustomerId == id select t.RentalId).FirstOrDefault();
            ViewBag.rid = rid;
            ViewBag.st = r.StartDate;
            ViewBag.et = r.EndDate;
            ViewBag.msg = i;
            var vehicle = ob.Vehicles.FirstOrDefault(v => v.VehicleId == rob.VehicleId);
            int amount = 0;
            if (vehicle?.Rentperday != null)
            {
                    int days = (endt.DayNumber - stdt.DayNumber) + 1;
                amount = days * vehicle.Rentperday.Value;
            }
            ViewBag.amount = amount;


            return View();
        }

        [HttpGet]
        public IActionResult Payment(int rentid, DateOnly stdt, DateOnly endt, int amount)
        {
            TempData["RentalId"] = rentid;
            TempData["Amount"] = amount;
            TempData["PaymentDate"] = DateTime.Now.ToShortDateString();
            TempData.Keep();
            return View();
        }



        [HttpPost]
        public IActionResult Payment(int rentid, DateOnly stdt, DateOnly endt, string Paymentmethod)
        {
            var rental = ob.Rentals.FirstOrDefault(r => r.RentalId == rentid);
            int amount = 0;
            if (rental != null && rental.VehicleId.HasValue)
            {
                var vehicle = ob.Vehicles.FirstOrDefault(v => v.VehicleId == rental.VehicleId.Value);
                if (vehicle?.Rentperday != null)
                {
                    int days = (endt.ToDateTime(TimeOnly.MinValue) - stdt.ToDateTime(TimeOnly.MinValue)).Days + 1;
                    amount = days * vehicle.Rentperday.Value;
                }
            }

            // Create and save payment
            var payment = new Payment
            {
                RentalId = rentid,
                Amount = amount,
                PaymentDate = DateOnly.FromDateTime(DateTime.Now),
                PaymentMethod = Paymentmethod
            };
            ob.Payments.Add(payment);

            if (rental != null)
            {
                rental.Status = "Completed";
            }  

            ob.SaveChanges();

            ViewBag.RentalId = rentid;
            ViewBag.Amount = amount;
            ViewBag.PaymentDate = DateTime.Now.ToShortDateString();
            ViewBag.Paymentmethod = Paymentmethod;
            ViewBag.Message = "Payment successful and saved!";

            return View();
        }



        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }


}
