using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numberIncrease : MonoBehaviour
{
    public Text theNumber;
    public Text uhOhTooSmall;
    public bool isItOnTheScreen = false;
    
    public float theNumberShallGoUp = 0f;
    public float numberMultiplier = 1f;

    public InputField MultiplierInput;
    public string theInputtedNumber;

    public void changedNumberMultiplier () {
        theInputtedNumber = MultiplierInput.text;
        numberMultiplier = float.Parse(theInputtedNumber);
    }

    public void enabledGame() {
        isItOnTheScreen = true;
    }

    public void disabledGame() {
        isItOnTheScreen = false;
    }
 
    // Start is called before the first frame update
    void Start()
    {
        uhOhTooSmall.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (isItOnTheScreen) {
            theNumber.text = "Number: " + (int)theNumberShallGoUp;
        
            if (Input.GetKeyDown("q")) {
                theNumberShallGoUp += numberMultiplier;
                uhOhTooSmall.gameObject.SetActive(false);
            } else if (Input.GetKeyDown("e")) {
                if (theNumberShallGoUp <= 0f) {
                    theNumberShallGoUp = 0f;
                    uhOhTooSmall.gameObject.SetActive(true);
                } else {
                    theNumberShallGoUp-= numberMultiplier;
                    uhOhTooSmall.gameObject.SetActive(false);
                }
            }
        }
    }
}
