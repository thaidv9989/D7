using System.Reflection;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using D7_ASPMVC.Models;
using D7_ASPMVC.Implement;
using D7_ASPMVC.Interfaces;


namespace D7_ASPMVC.Controllers;

public class PeopleController : Controller
{
    

    private readonly IPerson _person;
    
    public PeopleController(IPerson person)
    {
        _person = person;
    }

    public IActionResult Index()
    {
        return View(_person.GetAll());
    }

    public IActionResult Add(){
        return View();
    }

    [HttpPost]
    public IActionResult Add(PersonModel model){
        if(!ModelState.IsValid) return View();
        _person.Add(model);
        return RedirectToAction("Index");  
    }

    public IActionResult Edit(int ID){
       var person = _person.Detail(ID);
        return View(person);
    }
    [HttpPost]
    public IActionResult Edit(PersonModel model){
        if(!ModelState.IsValid) return View();
        _person.Edit(model);
        return RedirectToAction("Index");
    }


    public IActionResult Delete(int ID){
        var rs = _person.Delete(ID); 
        return RedirectToAction("Index");
    }

    public IActionResult Detail(int ID)
    {
        var std = _person.Detail(ID);
        return View(std);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
