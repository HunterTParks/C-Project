using System.Collections.Generic;

namespace Contact.Object
{
  public class Contact
  {
    private string _name;
    private string _number;
    private string _address;
    private static List<Contact> _allContacts = new List<Contact> {};

    public Contact(string newName, string newNumber, string newAddress)
    {
      _name = newName;
      _number = newNumber;
      _address = newAddress;
      _allContacts.add(this);
    }

    public string GetName()
    {
      return _name;
    }
    public string GetNumber()
    {
      return _number;
    }
    public string GetAddress()
    {
      return _address;
    }
    public static List<Contact> GetAll()
    {
      return _allContacts;
    }
  }
}
