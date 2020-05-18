using System;
namespace ClassesAndObjects
{
  public class Person
  {
    public int age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private string NickName;
    private int dead;


    public Person(string Nickname, int dead)
    {
      this.NickName = Nickname;
      this.dead = dead;
    }

    public Perso





    public void GetFullName()
    {
      Console.WriteLine("Get my full name {0} {1}.", FirstName, LastName);
    }
    public void Walk()
    {
      Console.WriteLine("I am walking");
    }
    public void Talk()
    {
      Console.WriteLine("I am talking");
    }
    public void Eat()
    {
      Console.WriteLine("I am eating");
    }
    public void Sleep()
    {
      Console.WriteLine("I am sleeping");
    }
    public string GetFullName(string FirstName, string LastName)
    {
      return $"The full name of the person is {FirstName} {LastName}";
    }
  }

  //public class SuperPerson : Person
  //{
  //  public void Fly()
  //  {
  //    Console.WriteLine("I am flying!");
  //  }


  //}
}
