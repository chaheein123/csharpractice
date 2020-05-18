using System;
using System.Collections.Generic;
using System.Net;
using ClassesAndObjects;

namespace csharpractice
{
  class Program
  {
    static void Main(string[] args)
    {
      Person me = new Person("Nickolodea", 12);
      me.FirstName = "Avetis";
      me.LastName = "Ghukasyan";

      me.GetFullName();
      me.Walk();
      me.Eat();
      me.Talk();
      me.Sleep();
      string fullName = me.GetFullName("Ian");
      me.age = 29;

      Console.WriteLine(fullName);
      Console.WriteLine(me.age);



    }
  }
}
