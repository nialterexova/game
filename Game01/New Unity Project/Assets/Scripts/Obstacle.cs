using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Unit Character = collider.GetComponent<Character>();
        if (Character && Character is Character)
       {
            Character.ReceiveDamage();
       }
    }
}
