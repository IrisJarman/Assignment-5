using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text playerName;
    public Text WordCount;
    public Text LettersCorrect;
    public Text LettersWrong;
    public Text PercentageCorrect;
    public int Percentage;
    public int total;
    public int wrong;
    public int right;

    private void Awake()
    {
        playerName.text = KeepData.PlayerName;
        WordCount.text = "Words Used: " + KeepData.wordCount.ToString();
        LettersCorrect.text = "Letters Correct: " + KeepData.LettersCorrect.ToString();
        LettersWrong.text = "Letters Incorrect: " + KeepData.LettersWrong.ToString();
        
    }

}
