using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class AppointmentsController : Controller
  {
    private readonly HairSalonContext _db;

    public AppointmentsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Appointment> model = _db.Appointments
      .Include(Appointments => Appointments.Stylist)
      .Include(Appointments => Appointments.Client).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Appointment Appointment)
    {
      _db.Appointments.Add(Appointment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Appointment thisAppointment = _db.Appointments.Include(Appointments => Appointments.Stylist).FirstOrDefault(Appointments => Appointments.AppointmentId == id);
      return View(thisAppointment);
    }

    public ActionResult Edit(int id)
    {
      var thisAppointment = _db.Appointments.FirstOrDefault(Appointments => Appointments.AppointmentId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(thisAppointment);
    }

    [HttpPost]
    public ActionResult Edit(Appointment Appointment)
    {
      _db.Entry(Appointment).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisAppointment = _db.Appointments.FirstOrDefault(Appointments => Appointments.AppointmentId == id);
      return View(thisAppointment);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisAppointment = _db.Appointments.FirstOrDefault(Appointments => Appointments.AppointmentId == id);
      _db.Appointments.Remove(thisAppointment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    // [HttpPost] 
    // public ActionResult Index(string name)
    // {
    //   List<Appointment> model = _db.Appointments.Include(Appointments => Appointments.Stylist).Where(x => x.Name.Contains(name)).ToList();      
    //   List<Appointment> sortedList = model.OrderBy(o => o.Title).ToList();
    //   ViewBag.filterName = "Filtering by: "+Title;
    //   return View("Index", sortedList);
    // }
  }
}