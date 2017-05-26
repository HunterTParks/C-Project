using Nancy;
using System.Collections.Generic;
using Contact.Object;

namespace Project
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/contacts/new"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        return View["confirmation.cshtml"];
      }
    }
  }
}
