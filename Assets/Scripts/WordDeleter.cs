using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDeleter : MonoBehaviour
{
    public Canvas canvas;
    public WordManager wordManager;
    private float minYpostition = -325f;
    void Update()
    {
        for (int i = 0; i < wordManager.words.Count; i++)
        {
            Word word = wordManager.words[i];
            RectTransform rectTransform = word.wordDisplay.text.GetComponent<RectTransform>();
            if (rectTransform.anchoredPosition.y < minYpostition)
            {
                wordManager.RemoveWord(word);
                Destroy(word.wordDisplay.gameObject);
            }
        }
    }
}
