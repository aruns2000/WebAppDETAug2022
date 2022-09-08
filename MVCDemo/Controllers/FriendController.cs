using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public static List<Friend> friends { get; set; }
        public  IActionResult Friend()
        {
            friends = new List<Friend>();
            friends.Add(new Friend { FriendID =1 , FriendName ="Vishwa",Place = "Belgaum" });
            friends.Add(new Friend { FriendID = 2, FriendName = "Vinay", Place = "Raychur" });
            return View(friends);
        }
    }
}
