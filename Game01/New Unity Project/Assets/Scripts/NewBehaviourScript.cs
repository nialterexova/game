using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(Movescene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Movescene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
