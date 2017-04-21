using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 0, max = 1000, guess;
    void Start()
    {
        initilization();
    }

    void initilization()
    {
        print("Hey Hello");
        print("Pick a number ");
        print("Can you let me know your range?");
        print("The highest number you can take is from " + min + " and " + max);
        guess = (min + max) / 2;
        print("Is ya guess " + guess + "or more or less");
        while (max == min)
        {
            max = max + 1;
        }

    }
    void NextGuess()
    {
        guess = (min + max) / 2;
        print("Is it " + guess);
        if (min == max)
        {
            print("its gotta be guess" +(guess+1));
        }
}
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess ;
                NextGuess();                                   
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                NextGuess();               
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                print("Viola I won");
            }
        }
    }