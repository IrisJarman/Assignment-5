using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{

	public List<Word> words;

	public WordSpawner wordSpawner;
	public AudioSource sources;

	private bool hasActiveWord;
	private Word activeWord;
	public static int wordcount;
	public static int LettersCorrect;
	public static int LettersIncorrect;
	

	public void AddWord()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);
		WordManager.wordcount++;
		KeepData.UpdateWordCount();
	}

	public void TypeLetter(char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
				sources.Play();
				WordManager.LettersCorrect++;
				KeepData.UpdateLettersCorrect();
			}
            else
            {
				LettersIncorrect++;
				KeepData.UpdateLettersIncorrect();
			}
		}
		else
		{
			foreach (Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					sources.Play();
					WordManager.LettersCorrect++;
					KeepData.UpdateLettersCorrect();
					break;
				}
				else
                {
					LettersIncorrect++;
					KeepData.UpdateLettersIncorrect();

				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
		}

	}
	public void RemoveWord(Word wordToRemove)
	{
		if (hasActiveWord && activeWord == wordToRemove)
        {
			hasActiveWord = false;
        }
		words.Remove(wordToRemove);

	}
 

}
