using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

    [SerializeField] TextMeshProUGUI guessText;

    int max = NumberTyper.Max;
    int min = NumberTyper.Min;
    int guess,guessCount,previousGuess;

    public void OnPressLower()
    {
        previousGuess = guess ;
        max = guess ;
        NextGuess();
    }

    // Use this for initialization
    void Start()
    {
        NextGuess();
    }

    void NextGuess()
    {
        AntiCheat();
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        guessCount++;
    }

    public void OnPressHigher()
    {
        previousGuess = guess;
        min = guess ;
        NextGuess();
    }

    void AntiCheat()
    {
        if (previousGuess == min && previousGuess == max)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }            
}
