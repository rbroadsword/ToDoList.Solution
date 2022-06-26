using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static List<string> result = new List<string> { };
  
    public static void Main()
  {
    Console.WriteLine("Welcome to the To Do List.");
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)"); 
    string userSelection = Console.ReadLine();

    if (userSelection == "Add")
    {
      AddToList(); 
    } else if (userSelection == "View")
    {
      ViewList(); 
    }

    static void AddToList()
    {
    Console.WriteLine("Enter the description for the new item");
    string description = Console.ReadLine(); 
    result.Add(description); 
    Console.WriteLine(description + " has been added to your list.");
    Main(); 
    }
  
    static void ViewList()
    {
      foreach (string item in result)
      Console.WriteLine(item + ", ");

      Main();
    }
  }
  }
}