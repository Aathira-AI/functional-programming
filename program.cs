using System;
using System.Linq;
using System.Collections.Generic;

public class Utils{

	//hold
	 public static List<string> GetNames(string[] names, string action , string searchKey){
		 
		 List<string> results=new List<string>();
		 switch(action){
			 case "StartsWith": 
				 	for(int i=0;i<names.Length;i++){
        					if(names[i].StartsWith("S")){
           						results.Add(names[i]);   
                            }
                     }
				 break;
			 case "EndsWith": 
				 	for(int i=0;i<names.Length;i++){
        					if(names[i].StartsWith("E")){
           						results.Add(names[i]);   
                            }
                     }
				 break;
		 }
		 return results;
     
	 }
	
	public static bool isStringStartsWithS(string item){
	    	return item.StartsWith("S");
	}
	public static bool isStringStartsWithJ(string item){
	    	return item.StartsWith("J");
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
      
        var results=Utils.GetNames(names,Utils.isStringStartsWithS);
        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
		 results=Utils.GetNames(names,Utils.isStringStartsWithJ);
        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
    }
}
