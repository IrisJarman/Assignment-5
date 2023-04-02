using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public static int wordCount;
    public static int LettersCorrect;
    public static int LettersWrong;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
    }
    public static void UpdateWordCount()
    {
        wordCount = WordManager.wordcount;
    }
    public static void UpdateLettersCorrect()
    {
        LettersCorrect = WordManager.LettersCorrect;
    }
    public static void UpdateLettersIncorrect()
    {
        LettersWrong = WordManager.LettersIncorrect;
    }
}
