using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers
{
  public class ParentsController : Controller
  {
    [HttpGet("/parents")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/parents/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}