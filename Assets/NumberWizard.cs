using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int max = 100;
        int min = 1;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Puch Enter = Correct");

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Up Arrow key is pressed.");
        }
		
	}
}
