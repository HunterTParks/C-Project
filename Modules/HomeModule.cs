using Nancy;
using System.Collections.Generic;

namespace Contact.Object
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contacts/new"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        newContact.AddToList();
        return View["confirmation.cshtml", newContact];
      };
    }
  }
}
