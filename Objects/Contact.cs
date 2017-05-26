using System.Collections.Generic;

namespace Contact.Object
{
  public class Contact
  {
    private string _name;
    private string _number;
    private string _address;
    private static List<Contact> _allContacts = new List<Contact> {};
    private int _id;
    private List<string> _contactInfo = new List<string>();

    public Contact(string newName, string newNumber, string newAddress)
    {
      _name = newName;
      _number = newNumber;
      _address = newAddress;
      _allContacts.Add(this);
      _id = _allContacts.Count;
      _contactInfo.Add(newNumber);
      _contactInfo.Add(newAddress);
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
    public static Contact Find(int searchId)
    {
      return _allContacts[searchId - 1];
    }
    public static List<string> GetInfo()
    {
      return _contactInfo;
    }
  }
}
