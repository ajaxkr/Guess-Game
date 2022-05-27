using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuesstheNumber : MonoBehaviour
{
    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int usersGuess;

    void Start()
    {
        guessNumber = Random.Range (0, 100);
    }

    public void CheckGuess()
    {
        usersGuess = int.Parse(input.text);

        if(usersGuess == guessNumber)
        {
            infoText.text = "You Guessed The Number!";
        } else if (usersGuess > guessNumber)
        {
            infoText.text = "Your Number Is Greater Than The Guess Number";
        } else if (usersGuess < guessNumber)
        {
            infoText.text = "Your Number Is Lower Than The Guess Number";
        }

        input.text = "";
    }

}

