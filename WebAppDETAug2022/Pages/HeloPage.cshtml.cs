using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Pages
{
    public class HeloPageModel : PageModel
    {
        public IHelo ob { get; set; }
        public  string Mesage{ get; set; }
        public string Message { get; private set; }

        public HeloPageModel(IHelo i)
        {
            ob = i;
        }

        public void OnGet()
        {
            Message = ob.SayHelo("Arun");
        }
    }
}
