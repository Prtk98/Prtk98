using System;

namespace prtk
{
  class csharplearn
  {
    static void Method(string fname, int age)
    {
      Console.WriteLine(fname + " is " + age);
    }

    static void Main(string[] args)
    {
      Method("Ram", 25);
      Method("Sita", 28);
      Method("Anjali", 31);
    }
  }
}
