using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentenceGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";
        int wordCount = 0;

        while (wordCount < 7)
        {
            string randomWord = words[Random.Range(0, words.Length)];
            sentence += randomWord + " ";
            wordCount++;
        }

        Debug.Log("Funny Sentence: " + sentence.Trim());
    }
}
