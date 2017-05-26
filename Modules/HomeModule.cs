using Nancy;
using System.Collections.Generic;
using System.Diagnostics;
using Contact.Object;

namespace Contact.Object
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml", Contact.GetAll()];
      };
      Get["/contacts"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contacts/new"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        return View["confirmation.cshtml", newContact];
      };
      Get["/contacts/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact selectedContact = Contact.Find(parameters.id);
        List<string> contactInformation = selectedContact.GetInfo();
        model.Add("contact", selectedContact);
        model.Add("contactinformation", contactInformation);
        return View["contact_view.cshtml", model];
      };
      Post["/contents/cleared"] = _ => {
        Contact.ClearAll();
        return View["cleared.cshtml"];
      };
    }
  }
}
