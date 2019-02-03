using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Venera : MonoBehaviour {
    public Button button;
    // Use this for initialization
    void Start () {
        button.onClick.AddListener(Movescene2);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Movescene2()
    {
        SceneManager.LoadScene("Venera");
    }
}
