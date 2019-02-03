using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitFinishLine : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject hitObj = collider.gameObject;
        if (hitObj.tag == "Player")
        {
            SceneManager.LoadScene("Win");
        }
    }
}
