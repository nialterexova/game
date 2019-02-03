using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sun : Unit {

    private Image sun;
    public float startingTime;

    // Use this for initialization
    void Start () {

        sun = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {

        startingTime -= Time.deltaTime;

        if (startingTime <= 1)
        {
            sun.enabled = true;
        }
    }
}
