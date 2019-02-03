using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Mercury : MonoBehaviour {

    public Button button;

    // Use this for initialization
    void Start () {
        button.onClick.AddListener(Movescene1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Movescene1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
