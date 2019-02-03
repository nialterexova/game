using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class win : MonoBehaviour {

    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(Game);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }


}
