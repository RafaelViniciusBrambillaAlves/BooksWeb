using Microsoft.AspNetCore.Mvc;
using BooksWeb.Models;

namespace BooksWeb.Controllers;

public class ReaderController: Controller {

    private readonly BookDatabase db;

    public ReaderController(BookDatabase db){
        this.db = db;
    } 

    public ActionResult Read(){
        return View(db.Readers.ToList());
    }

    [HttpGet]
    public ActionResult Create(){
        return View();
    }

    [HttpPost]
    public ActionResult Create(Reader model){
        db.Readers.Add(model);
        db.SaveChanges();
        return RedirectToAction("Read");
    }

    public ActionResult Delete(int id) 
    {
        var reader = db.Readers.Single(e => e.ReaderId == id); 

        db.Readers.Remove(reader); 
        
        db.SaveChanges(); 

        return RedirectToAction("Read");
    }

    [HttpGet]
    public ActionResult Update(int id)
    {
        Reader reader = db.Readers.Single(e => e.ReaderId == id);
        return View(reader);
    }

    [HttpPost]
    public ActionResult Update(int id, Reader model)
    {
        var reader = db.Readers.Single(e => e.ReaderId == id);

        reader.Name = model.Name;
        reader.Email = model.Email;
        reader.Password = model.Password;

        db.SaveChanges();

        return RedirectToAction("Read");
    }

}