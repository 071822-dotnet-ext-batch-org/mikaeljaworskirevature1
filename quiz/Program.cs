using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
public static int checkForALetter(List<string> stringList, string letter){
        //WRITE YOUR CODE HERE
        int occurs = stringList.Count(x => (x == letter));
        
        
        
    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        string[] inputArray = Console.ReadLine().Replace("[","").Replace("]","").Split(",");
        string letter = Console.ReadLine();
		List<string> stringList = new List<string>();
		for(int i=0;i<inputArray.Length;i++){
		    stringList.Add(inputArray[i]);
		}
        Console.WriteLine(checkForALetter(stringList, letter));
    }
}