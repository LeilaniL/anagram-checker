using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
  public class Program
  {
        public static void Main()
        {
             Console.WriteLine("Enter a word");
             string mainWord= Console.ReadLine();
             List<string> possibleAnagrams = new List<string>{};
             bool exitLoop=false;
            do 
            {
               Console.WriteLine("Enter an anagram"); 
               possibleAnagrams.Add(Console.ReadLine());
               Console.WriteLine("Do you have another word? (Y/N)"); 
               string addMoreWord= Console.ReadLine();
               if (addMoreWord=="N")
               {
                   exitLoop=true;
               }
            } while(!exitLoop);
            Anagram anagram= new Anagram(mainWord,possibleAnagrams);
            anagram.CreateAnagrams();
            List<string> showAll = anagram.Get_anagrams();
                    for (int i=0;i<showAll.Count;i++)
                    {
                        Console.WriteLine(showAll[i]);
                    }
        }
  }
}