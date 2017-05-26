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
    private List<string> _contactInfo;

    public Contact(string newName, string newNumber, string newAddress)
    {
      _name = newName;
      _number = newNumber;
      _address = newAddress;
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
    public void SetID()
    {
      _id = _allContacts.Count;
    }
    public static List<Contact> GetAll()
    {
      return _allContacts;
    }
    public void AddToList()
    {
      _allContacts.Add(this);
    }
    public static Contact Find(int searchId)
    {
      return _allContacts[searchId - 1];
    }
    public List<string> GetInfo()
    {
      return _contactInfo;
    }
  }
}
