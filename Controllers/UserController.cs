using LAB03.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB03.Controllers
{
    public class UserController : Controller
    {
        static List<Lab> users = new List<Lab>()
        {
            new Lab() {Id="1", Name="aaa", PassWord = "1", Email="111", Phone="111"},
            new Lab() {Id="2", Name="aaa", PassWord = "1", Email="111", Phone="111"},
            new Lab() {Id="3", Name="aaa", PassWord = "1", Email="111", Phone="111"},
            new Lab() {Id="4", Name="aaa", PassWord = "1", Email="111", Phone="111"},
            new Lab() {Id="5", Name="aaa", PassWord = "1", Email="111", Phone="111"}

        };
        public IActionResult Index()
        {
            return View(users);
        }
    }
}
