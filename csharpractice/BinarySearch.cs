using System;
using System.Collections.Generic;

namespace csharpractice
{
  public class BS
  {
    public static void binaryS()
    {
      List<int> myList = new List<int>();
      myList.Add(1);
      myList.Add(3);
      myList.Add(22);
      myList.Add(33);
      myList.Add(44);
      myList.Add(55);
      myList.Add(66);
      myList.Add(99);

      var yoyo = myList.BinarySearch(20);

      Console.WriteLine(yoyo);
    }
  }
}