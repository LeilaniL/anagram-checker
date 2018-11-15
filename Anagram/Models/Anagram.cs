using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
  public class Anagram
  {
    private string _MainWord;
    private  List<string> _Targets = new List<string> {};
    private  List<string> _anagrams = new List<string> {};


    public Anagram (string userWord, List<string> userTargets)
    {
      _MainWord = userWord;
      _Targets= userTargets;
    }
    public void CreateAnagrams()
    {
            char[] mainChar = _MainWord.ToCharArray();
            Array.Sort(mainChar);


        for (int i=0;i<_Targets.Count;i++)
        {
            char[] targetChar = _Targets[i].ToCharArray();
            Array.Sort(targetChar);
            if (mainChar.SequenceEqual(targetChar))
            {
                _anagrams.Add(_Targets[i]);
            }
        }
    }
    public List<string> Get_anagrams()
    {
      return _anagrams;
    }

  }
}