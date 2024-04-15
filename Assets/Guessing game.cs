using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
//using System;

public class Guessinggame : MonoBehaviour
{
    [SerializeField] private TMP_InputField put;
    int randNum;
    int trys = 3;
    [SerializeField] private TMP_Text numbs;
    [SerializeField] private TMP_Text header;
    [SerializeField] private TMP_Text PlaceHolder;

    void Input()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        GameSetup();

      
    }
    // Update is called once per frame
    void Update()
    {
      
    }
    public void GameSetup()
    {
      
        randNum = (Random.Range(1, 11));
        Debug.Log(randNum);

    }

    public void GetInput()
    {
       
        string myAnswer = put.text;

        if (myAnswer == "")
        {
            header.text = "Please enter a number";
            return;
            
        }

       // Debug.Log(myAnswer);

        int answer = int.Parse(put.text);

        //PlaceHolder.text = "Enter Number";
        //return;

        if (answer == randNum)//correct
        {
            //cout("")
            

            header.text = "You got it, would you like to play again?";

            
        }
        else if (answer != randNum)//wrong
        {
            // PlaceHolder.text = "Enter Number";

            if (trys == 3)
            {
                // cout("Try again)
                header.text = "Nope, try again";

                trys = trys - 1;
            }
            else if (trys == 2)
            {
                header.text = "One more chance";
                trys = trys - 1;
            }
            else
            {
                header.text = "Game Over";
                trys = trys - 1;
            }

           
            if (trys == 0)
                {
                    Restart();
                    trys = 3;
                }

        }
        myAnswer = "Enter number";

        numbs.text = trys.ToString();
    }
    public void Restart()
    {
        header.text = "There's a number between one 1 and 10. Can you guess it?";
        GameSetup();
    }
}

