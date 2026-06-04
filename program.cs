using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names =
        {
            "Sam",
            "John",
            "Steve",
            "Alice",
            "Sarah",
            "Bob"
        };
      List<string> results=new List<string>();
      for(int i=0;i<names.Length;i++){
        if(names[i].StartsWith("S")){
           results.add(names[i]);   
        }
      }

        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
    }
}
