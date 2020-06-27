using System;
using System.Collections;

namespace csharpractice
{
  public class Util
  {
    public static void LoopConsole(IEnumerable Lists)
    {
      foreach (var element in Lists)
      {
        Console.WriteLine(element);
      }
    }
  }
}
