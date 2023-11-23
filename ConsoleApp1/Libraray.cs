// Library for game to use containing words. Different lists within the class
using System;
using System.Collections.Generic;

class WordLibrary
{
    public List<string> Fiveletter {get; private set; }
    
    public WordLibrary()
    {
       Fiveletter =new List<string>
       {
       {"apple","peach","melon"}; //insert words between {}
       };
    }

    public string GetRandomFiveletter()
    {
        return GetRandomWord(Fiveletter);
    }
    // if you want to add a 6 letter list repeat above with new string and list



private string GetRandomWord(List<string> wordList)
{
    Random random = new Random();
    int index = random.Next(wordList.Count);
    return wordList[index]:

}
}