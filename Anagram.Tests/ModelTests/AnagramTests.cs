using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Anagram.Tests
{

    [TestClass]
    public class AnagramTest{
    
        [TestMethod]
        public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
        {
         List<string> listForConstructor = new List<string> {}; 

        listForConstructor.Add("aaaa");
        listForConstructor.Add("bbbb");

        Anagram newAnagram = new Anagram("test", listForConstructor);
        Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
        }

        [TestMethod]
        public void AnagramConstructor_ScramblesLettersOfWord_List()
        {
         List<string> listForConstructor = new List<string> {"tab", "book", "abt"};
         List<string> resultList = new List<string> {"tab", "abt"}; 


        Anagram newAnagram = new Anagram("bat", listForConstructor);

        newAnagram.CreateAnagrams();
        CollectionAssert.AreEqual(resultList, newAnagram.Get_anagrams());
        }
  }
}

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   //Act
    //   string result = newItem.GetDescription();

    //   //Assert
    //   Assert.AreEqual(description, result);
    // }

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newItem.SetDescription(updatedDescription);
    //   string result = newItem.GetDescription();

    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   //Arrange
    //   List<Item> newList = new List<Item> { };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

//   }
// }