using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    public int max = 1000;
    private int currentMax = 1000;

    public int min = 1;
    private int currentMin = 1;
        
    private int guess = 0;

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpdateGuess(guess, currentMax);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            UpdateGuess(currentMin, guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I knew it.");
            StartGame();
        }
    }

    private void StartGame()
    {
        Debug.Log("Welcome to Number Wizard.");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowst number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than than 500");
        Debug.Log("Up Arrow = Higher, Down Arrow = Lower, Enter = Correct");

        UpdateGuess(min, max + 1);
    }

    private void UpdateGuess(int min, int max)
    {
        currentMin = min;
        currentMax = max;

        guess = (currentMax + currentMin) / 2;
        Debug.Log("Is it higher or lower than... " + guess);
    }
}
