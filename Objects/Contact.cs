using System.Collections.Generic;

namespace Contact.Object
{
  public class Contact
  {
    private string _name;
    private string _number;
    private string _address;

    public Contact(string newName, string newNumber, string newAddress)
    {
      _name = newName;
      _number = newNumber;
      _address = newAddress;
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
  }
}
