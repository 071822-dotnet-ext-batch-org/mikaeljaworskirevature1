using System;

namespace console5app
{
    class Program
    {
    static void Main(string[] args){
        string[] strings = {"apple", "banana", "plum", "strawberry"};
        Console.WriteLine(findOccurences(strings));    
    }
     
    static int findOccurences(string[] sArray){
  	    int counter = 0;
        foreach(string str in sArray){
    	    foreach(char ch in str){
        	    if (ch == 'a'){
            	    counter++;
                }
            }
        }
        return counter;
    }
    }
}
