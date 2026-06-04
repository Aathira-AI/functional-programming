using System;
using System.Linq;
using System.Collections.Generic;

public class Utils{

	public static Func<string,bool> GetPredicateForStringStartsWith(string searchKey){
		
		Func<string,bool> isStrinStartswithGivenCharcterPredicate=(item)=>{return item.StartsWith(searchKey);};
		
		return isStrinStartswithGivenCharcterPredicate;
	}
	
	
	
	public static List<string> GetNames(string[] names,Func<string,bool> predicate){
		 
		 List<string> results=new List<string>();
		 for(int i=0;i<names.Length;i++){
        					if(predicate(names[i])){
           						results.Add(names[i]);   
                            }
                     }
				 
		 return results;
     
	 }
}

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
      
        var results=Utils.GetNames(names,Utils.GetPredicateForStringStartsWith("S"));
        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
		 results=Utils.GetNames(names,Utils.GetPredicateForStringStartsWith("J"));
        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
    }
}
