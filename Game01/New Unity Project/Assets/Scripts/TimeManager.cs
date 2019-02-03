using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    public float startingTime;

    private Text theText;

    private Character character;
    
    // Use this for initialization

    // Use this for initialization
    void Start () {

        character = FindObjectOfType<Character>();
        theText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        startingTime -= Time.deltaTime;

        theText.text = "" + Mathf.Round (startingTime);

        if (startingTime <= 0)
        {
            character.ReceiveDamage(); 
        }

	}
}
