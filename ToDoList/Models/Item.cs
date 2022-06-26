using System.Collections.Generic;
using System; 
namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private string _add;
    private string _view;

    public Item(string description, string add, string view)
    {
      _description = description;
      _add = add;
      _view = view;
    }

    public string GetDescription()
  {
    return _description;
  }
    /*public bool IsString(string _description)
    {
      return (_add = typeof(string));
    }*/ 
    public static void ClearAll()
    {
      _instances.Clear(); 
    }
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public Item(string description)
    {
      Description = description; 
      _instances.Add(this);
    } 
  }
}