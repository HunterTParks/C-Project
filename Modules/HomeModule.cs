using Nancy;
using System.Collections.Generic;

namespace Contact.Object
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml", Contact.GetAll()];
      };
      Get["/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contacts/new"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        return View["confirmation.cshtml", newContact];
      };
      Get["/contacts/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Contact selectedContact = Contact.Find(parameters.id);
        List<string> contactInformation = Contact.GetInfo();
        model.Add("contact", selectedContact);
        model.Add("contactinformation", contactInformation);
        return View["contact_view.cshtml", model];
      };
    }
  }
}
